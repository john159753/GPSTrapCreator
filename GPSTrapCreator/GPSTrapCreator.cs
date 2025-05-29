using GMap.NET;
using GMap.NET.WindowsForms;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace GPSTrapCreator
{
    public partial class GPSTrapCreator : Form
    {
        GMapOverlay overlayOne;
        GMapOverlay overlayTwo;
        GMapOverlay polyOverlay;
        List<GpsZone> Zones = new List<GpsZone>();
        private GMapControl _searcher = new GMapControl();
        //double horizontalSpread = 0.00023;
        //double verticalSpread = 0.00006;
        List<CsvOutput> csvZones = new List<CsvOutput>();
        public GPSTrapCreator()
        {
            InitializeComponent();
            _btnExport.Enabled = false;
        }


        private void mapComponent_Load(object sender, EventArgs e)
        {
            
            

            _mapComponent.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
            var res = _searcher.SetPositionByKeywords("AutoBahn Country Club");
            _mapComponent.Position = _searcher.Position;
            _mapComponent.MinZoom = 3;
            _mapComponent.MaxZoom = 20;
            _mapComponent.Zoom = 16;
            _mapComponent.Manager.Mode = AccessMode.ServerAndCache;

            overlayOne = new GMapOverlay("Trap Locations");
            overlayTwo = new GMapOverlay("Trap Locations");
            polyOverlay = new GMapOverlay("polygons");

        }

        private void mapComponent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_rdoZones.Checked)
            {

                var mCoord = _mapComponent.FromLocalToLatLng(e.X, e.Y);
                var gmg = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                _mapComponent.Overlays.Add(overlayOne);
                overlayOne.Markers.Add(new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green));
                _dg1.DataSource = null;
                _dg1.DataSource = overlayOne.Markers;


            }
            else
            {
                var mCoord = _mapComponent.FromLocalToLatLng(e.X, e.Y);
                var gmg = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                _mapComponent.Overlays.Add(overlayTwo);
                overlayTwo.Markers.Add(new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot));
                _dg1.DataSource = null;
                _dg1.DataSource = overlayTwo.Markers;

            }

        }

        private void mapComponent_MarkerClicked(GMapMarker item, MouseEventArgs e)
        {
            var msgBox = MessageBox.Show("Are you sure you would like to remove this marker? If you say no -- for some unknown reason it asks for as many times as there was an eventhandler registered", "Confirmation", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                if (_rdoZones.Checked)
                {

                    overlayOne.Markers.Remove(item);
                    _dg1.DataSource = null;
                    _dg1.DataSource = overlayOne.Markers;

                }
                else
                {
                    overlayTwo.Markers.Remove(item);
                    _dg1.DataSource = null;
                    _dg1.DataSource = overlayTwo.Markers;
                }
            }
        }



        private void rdoAngles_CheckedChanged(object sender, EventArgs e)
        {
            if (_rdoZones.Checked)
            {
                _dg1.DataSource = null;
                _dg1.DataSource = overlayOne.Markers;


            }
            else
            {
                _dg1.DataSource = null;
                _dg1.DataSource = overlayTwo.Markers;
            }
        }

        private void rdoZones_CheckedChanged(object sender, EventArgs e)
        {
            if (_rdoZones.Checked)
            {
                _dg1.DataSource = null;
                _dg1.DataSource = overlayOne.Markers;

            }
            else
            {
                _dg1.DataSource = null;
                _dg1.DataSource = overlayTwo.Markers;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if(overlayOne.Markers.Count != overlayTwo.Markers.Count)
            {
                MessageBox.Show("Amount of traps and angles dont equal.. you should have an angle marker for every single trap.");
                return;
            }
            // Parse the width and height values from the text boxes
            double trapPolyWidth;
            double trapPolyHeight;

            if (!double.TryParse(txt_trapPolyWidth.Text, out trapPolyWidth))
            {
                MessageBox.Show("Invalid value for trap polygon width. Please enter a valid number.");
                return;
            }

            if (!double.TryParse(txt_trapPolyHeight.Text, out trapPolyHeight))
            {
                MessageBox.Show("Invalid value for trap polygon height. Please enter a valid number.");
                return;
            }
            List<GpsZone> preZones = new List<GpsZone>();
            List<List<PointLatLng>> mapPolys = new List<List<PointLatLng>>();
            for (int i = 0; i < overlayOne.Markers.Count(); i++)
            {
                var pnt = overlayOne.Markers[i];
                var ang = overlayTwo.Markers[i];

                var at2 = Math.Atan2((ang.Position.Lng - pnt.Position.Lng), (ang.Position.Lat - pnt.Position.Lat));

                if (at2 < 0)
                    at2 += (Math.PI) * 2;

                GpsZone zone = new GpsZone();
                zone.Latitude = pnt.Position.Lat;
                zone.Longitude = pnt.Position.Lng;
                zone.HeadingAngle = (int)(at2 * 57.2957795130823209);
                preZones.Add(zone);
            }
            foreach (var zone in preZones)
            {
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(new PointLatLng(zone.Latitude - (trapPolyHeight / 2), zone.Longitude - (trapPolyWidth / 2)));
                points.Add(new PointLatLng(zone.Latitude + (trapPolyHeight / 2), zone.Longitude - (trapPolyWidth / 2)));
                points.Add(new PointLatLng(zone.Latitude + (trapPolyHeight / 2), zone.Longitude + (trapPolyWidth / 2)));
                points.Add(new PointLatLng(zone.Latitude - (trapPolyHeight / 2), zone.Longitude + (trapPolyWidth / 2)));


                if (zone.HeadingAngle != 0)
                {
                    List<PointLatLng> tmppoints = new List<PointLatLng>();
                    foreach (var pnt in points)
                    {
                        var tranformed = TransformPoint(pnt.Lat, pnt.Lng, zone.HeadingAngle, zone.Latitude, zone.Longitude);
                        tmppoints.Add(new PointLatLng(tranformed["X"], tranformed["Y"]));
                    }
                    points.Clear();
                    points = tmppoints;
                }
                mapPolys.Add(points);
            }
            int zoneCount = 0;
            foreach (var poly in mapPolys)
            {
                GMapPolygon zoneBounds = new GMapPolygon(poly, $"Zone {zoneCount}");
                zoneBounds.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                zoneBounds.Stroke = new Pen(Color.Red, 1);
                polyOverlay.Polygons.Add(zoneBounds);
                _mapComponent.Overlays.Add(polyOverlay);

                zoneCount++;
            }


            foreach (var p in polyOverlay.Polygons)
            {
                CsvOutput zone = new CsvOutput();


                zone.ZoneName = p.Name;

                var lats = p.Points.Select(lat => (int)(lat.Lat * 10000000));
                var lngs = p.Points.Select(lng => (int)(lng.Lng * 10000000));

                zone.Lat1 = lats.ToArray()[0];
                zone.Lat2 = lats.ToArray()[1];
                zone.Lat3 = lats.ToArray()[2];
                zone.Lat4 = lats.ToArray()[3];
                zone.Lng1 = lngs.ToArray()[0];
                zone.Lng2 = lngs.ToArray()[1];
                zone.Lng3 = lngs.ToArray()[2];
                zone.Lng4 = lngs.ToArray()[3];



                zone.ZoneCount = polyOverlay.Polygons.Count;
                csvZones.Add(zone);
            }


            _rdoAngles.Enabled = false;
            _rdoZones.Enabled = false;
            _dg1.DataSource = null;
            _dg1.DataSource = csvZones;
            _btnExport.Enabled = true;
            MessageBox.Show("Processing Done, You can export now.");
        }

        private Dictionary<string, double> TransformPoint(double x1, double y1, int rotation, double midX, double midY)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();

            double dx = x1 - midX;
            double dy = y1 - midY;
            double radians = DegreeToRadian(rotation);
            x1 = (dx * Math.Cos(radians)) - (dy * Math.Sin(radians));
            y1 = (dx * Math.Sin(radians)) + (dy * Math.Cos(radians));

            x1 = x1 + midX;
            y1 = y1 + midY;

            result.Add("X", x1);
            result.Add("Y", y1);
            return result;
        }
        private double DegreeToRadian(int angle)
        {
            return (Math.PI * angle / 180.0);
        }
        public class GpsZone
        {

            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public int HeadingAngle { get; set; }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            _btnExport.Enabled = false;
            overlayOne.Clear();
            overlayTwo.Clear();
            polyOverlay.Clear();
            Zones.Clear();
            csvZones.Clear();
            _rdoAngles.Enabled = true;
            _rdoZones.Enabled = true;
            _rdoZones.Select();
            _dg1.DataSource = null;
            _dg1.DataSource = overlayOne.Markers;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchResult = _searcher.SetPositionByKeywords(_txtSearch.Text);
            _mapComponent.Position = _searcher.Position;
            if (searchResult == GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                _mapComponent.Zoom = 16;
            }
            else
            {
                MessageBox.Show(searchResult.ToString());
            }

        }


        void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void txt_trapPolyHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }
        private void txt_trapPolyWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot, and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void BtnToCsv_Click(object sender, EventArgs e)
        {





            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
            save.InitialDirectory = @"C:\Users\John\Documents\";
            save.Title = "Save Trap File";
            save.ShowDialog();



            // If the file name is not an empty string open it for saving.  
            if (save.FileName != "")
            {
                using (StreamWriter outputFile = new StreamWriter(save.FileName))
                {
                    foreach (var line in csvZones)
                    {
                        outputFile.WriteLine($"{line.ZoneName},{line.Lat1},{line.Lat2},{line.Lat3},{line.Lat4},{line.Lng1},{line.Lng2},{line.Lng3},{line.Lng4},{line.ZoneCount}");
                    }

                }
            }

        }
    }
    public class CsvOutput
    {

        // ZoneName,Lat1,Lat2,Lat3,Lat4,Lng1,Lng2,Lng3,Lng4,ZoneCount
        public string ZoneName { get; set; }
        public int Lat1 { get; set; }
        public int Lat2 { get; set; }
        public int Lat3 { get; set; }
        public int Lat4 { get; set; }
        public int Lng1 { get; set; }
        public int Lng2 { get; set; }
        public int Lng3 { get; set; }
        public int Lng4 { get; set; }
        public int ZoneCount { get; set; }


    }

}
