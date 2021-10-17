using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace OMG
{
    public partial class extract : Form
    {
        public extract()
        {
            InitializeComponent();
        }

        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //Important.DO NOT CHANGE!!!

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }

        private void extract_Load(object sender, EventArgs e)
        {
            Extract("ERROR408", ".\\", "extract", "AxInterop.WMPLib.dll"); //Extract
            Extract("ERROR408", ".\\", "extract", "Interop.WMPLib.dll"); //Extract
            Extract("ERROR408", ".\\", "extract", "error.mp4"); //Extract
            Extract("ERROR408", ".\\", "extract", "del.bat"); //Extract
            VideoPlay.Start();
        }

        private void deleteExtractFiles_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            deleteExtractFiles.Stop();
        }

        private void VideoPlay_Tick(object sender, EventArgs e)
        {
            var video = new video();
            video.Show();

            VideoPlay.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process.Start(@"del.bat");
            timer1.Stop();
            Application.Exit();
        }
    }
}
