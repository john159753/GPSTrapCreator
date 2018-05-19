using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET;
using System.IO;


namespace GPSTrapCreator
{
    public partial class GPSTrapCreator : Form
    {
        GMapOverlay overlayOne;
        GMapOverlay overlayTwo;
        GMapOverlay polyOverlay;
        List<gpsZone> Zones = new List<gpsZone>();
        double horizontalSpread = 0.00023;
        double verticalSpread = 0.00006;
        List<CsvOutput> csvZones = new List<CsvOutput>();
        public GPSTrapCreator()
        {
            InitializeComponent();
        }


        private void mapexplr_Load_1(object sender, EventArgs e)
        {
            mapexplr.SetPositionByKeywords("Gingerman Raceway");

            mapexplr.MapProvider = GMap.NET.MapProviders.BingSatelliteMapProvider.Instance;
            mapexplr.MinZoom = 3;
            mapexplr.MaxZoom = 20;
            mapexplr.Zoom = 16;
            mapexplr.Manager.Mode = AccessMode.ServerAndCache;

            overlayOne = new GMapOverlay("Trap Locations");
            overlayTwo = new GMapOverlay("Trap Locations");
            polyOverlay = new GMapOverlay("polygons");
  
        }

        private void mapexplr_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (rdoZones.Checked)
            {

                var mCoord = mapexplr.FromLocalToLatLng(e.X, e.Y);
                var gmg = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                mapexplr.Overlays.Add(overlayOne);
                overlayOne.Markers.Add(new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green));
                dg1.DataSource = null;
                dg1.DataSource = overlayOne.Markers;
                

            }
            else
            {
                var mCoord = mapexplr.FromLocalToLatLng(e.X, e.Y);
                var gmg = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                mapexplr.Overlays.Add(overlayTwo);
                overlayTwo.Markers.Add(new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(mCoord.Lat, mCoord.Lng), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot));
                dg1.DataSource = null;
                dg1.DataSource = overlayTwo.Markers;

            }
            
        }
   
        private void mapMarkerClicked(GMapMarker item, MouseEventArgs e)
        {
            var msgBox = MessageBox.Show("Are you sure you would like to remove this marker?","Confirmation", MessageBoxButtons.YesNo);
            if (msgBox == DialogResult.Yes)
            {
                if (rdoZones.Checked)
                {

                    overlayOne.Markers.Remove(item);
                    dg1.DataSource = null;
                    dg1.DataSource = overlayOne.Markers;

                }
                else
                {
                    overlayTwo.Markers.Remove(item);
                    dg1.DataSource = null;
                    dg1.DataSource = overlayTwo.Markers;
                }
            }  
        }



        private void rdoAngles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoZones.Checked)
            {
                dg1.DataSource = null;
                dg1.DataSource = overlayOne.Markers;


            }
            else
            {
                dg1.DataSource = null;
                dg1.DataSource = overlayTwo.Markers;
            }
        }

        private void rdoZones_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoZones.Checked)
            {
                dg1.DataSource = null;
                dg1.DataSource = overlayOne.Markers;
                
            }
            else
            {
                dg1.DataSource = null;
                dg1.DataSource = overlayTwo.Markers;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            List<gpsZone> preZones = new List<gpsZone>();
            List<List<PointLatLng>> mapPolys = new List<List<PointLatLng>>();
            for (int i = 0; i < overlayOne.Markers.Count(); i++)
            {
                var pnt = overlayOne.Markers[i];
                var ang = overlayTwo.Markers[i];

                var at2 = Math.Atan2((ang.Position.Lng - pnt.Position.Lng), (ang.Position.Lat - pnt.Position.Lat));

                if (at2 < 0)
                    at2 += (Math.PI) * 2;

                gpsZone zone = new gpsZone();
                zone.Lat = pnt.Position.Lat;
                zone.Lng = pnt.Position.Lng;
                zone.headingAngle = (int)(at2 * 57.2957795130823209);
                preZones.Add(zone);
            }
            foreach (var zone in preZones)
            {
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(new PointLatLng(zone.Lat - (verticalSpread / 2), zone.Lng - (horizontalSpread / 2)));
                points.Add(new PointLatLng(zone.Lat + (verticalSpread / 2), zone.Lng - (horizontalSpread / 2)));
                points.Add(new PointLatLng(zone.Lat + (verticalSpread / 2), zone.Lng + (horizontalSpread / 2)));
                points.Add(new PointLatLng(zone.Lat - (verticalSpread / 2), zone.Lng + (horizontalSpread / 2)));
                

                if (zone.headingAngle != 0)
                {
                    List<PointLatLng> tmppoints = new List<PointLatLng>();
                    foreach (var pnt in points)
                    {
                        var tranformed = TransformPoint(pnt.Lat, pnt.Lng, zone.headingAngle, zone.Lat, zone.Lng);
                        tmppoints.Add(new PointLatLng(tranformed["X"], tranformed["Y"]));
                    }
                    points.Clear();
                    points = tmppoints;
                }
                mapPolys.Add(points);
            }
            int zoneCount = 0;
            foreach(var poly in mapPolys)
            {
                GMapPolygon zoneBounds = new GMapPolygon(poly, $"Zone {zoneCount}");
                zoneBounds.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
                zoneBounds.Stroke = new Pen(Color.Red, 1);
                polyOverlay.Polygons.Add(zoneBounds);
                mapexplr.Overlays.Add(polyOverlay);
                
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


            rdoAngles.Enabled = false;
            rdoZones.Enabled = false;
            dg1.DataSource = null;
            dg1.DataSource = csvZones;
            MessageBox.Show("Processing Done, You can export now.");
        }

        private Dictionary<string,double> TransformPoint(double x1, double y1, int rotation, double midX, double midY )
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
        public class gpsZone
        {

            public double Lat { get; set; }
            public double Lng { get; set; }
            public int headingAngle { get; set; }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            overlayOne.Clear();
            overlayTwo.Clear();
            polyOverlay.Clear();
            Zones.Clear();
            csvZones.Clear();
            rdoAngles.Enabled = true;
            rdoZones.Enabled = true;
            rdoZones.Select();
            dg1.DataSource = null;
            dg1.DataSource = overlayOne.Markers;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchResult = mapexplr.SetPositionByKeywords(txtSearch.Text);
            if (searchResult == GeoCoderStatusCode.G_GEO_SUCCESS)
            {
                mapexplr.Zoom = 16;
            }
            else
            {
                MessageBox.Show(searchResult.ToString());
            }
            
        }


         void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
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
                    foreach(var line in csvZones )
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
