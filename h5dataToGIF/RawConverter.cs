using System;
using System.IO;
using System.Drawing;

namespace h5dataToGIF
{
    class RawConverter
    {
        #region Properties
        private string _rawDataLocation;

        public string RawDataLocation
        {
            get { return _rawDataLocation; }
            set { _rawDataLocation = value; }
        }

        private string _paletteLocation;

        public string PaletteLocation
        {
            get { return _paletteLocation; }
            set { _paletteLocation = value; }
        }

        private string _saveFile;

        public string SaveFile
        {
            get { return _saveFile; }
            set { _saveFile = value; }
        }

        private int _imgWidth;

        public int ImageWidth
        {
            get { return _imgWidth; }
            set { _imgWidth = value; }
        }

        private int _imgHeight;

        public int ImageHeight
        {
            get { return _imgHeight; }
            set { _imgHeight = value; }
        }

        #endregion      

        public RawConverter(int ImageWidth, int ImageHeight)
        {
            this.ImageWidth = ImageWidth;
            this.ImageHeight = ImageHeight;
        }

        public void ConvertData()
        {
            if ((RawDataLocation != null) && (PaletteLocation != null) && (SaveFile != null))
            {
                try
                {
                    Color[] _palette = GetPalette(PaletteLocation);
                    PixelLine[] _pixelData = GetDataBlock(_palette);

                    Bitmap image = new Bitmap(ImageWidth, ImageHeight);
                    for (int i=0; i<_pixelData.Length; i++)
                    {
                        PixelLine pl = _pixelData[i];
                        for (int j = 0; j < pl.LineData.Length; j++)
                        {
                            image.SetPixel(j, i, pl.LineData[j]);
                        }
                    }
                    if (_saveFile.Substring(_saveFile.Length - 3, 3) == "jpg")
                    {
                        image.Save(_saveFile, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        image.Save(_saveFile, System.Drawing.Imaging.ImageFormat.Gif);
                    }
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        /// <summary>
        /// Fetches all pixels from the raw datafile and returns an array of PixelLine objects
        /// </summary>
        /// <param name="Palette">Color Palette used to decode the raw color coding</param>
        /// <returns></returns>
        private PixelLine[] GetDataBlock(Color[] Palette)
        {
            PixelLine[] pixelData = new PixelLine[_imgHeight];
            //populate all lines
            for (int i=0; i<_imgHeight; i++)
            {
                pixelData[i] = new PixelLine(_imgWidth);
            }

            try
            {
                using (StreamReader sr = new StreamReader(RawDataLocation))
                {
                    while (!sr.EndOfStream)
                    {
                        string data = sr.ReadLine();
                        data = data.Trim();
                        if (data != "")
                        {
                            string[] lineData = data.Split(':');
                            //pixel coordinates
                            lineData[0] = lineData[0].Trim(new char[] { '(', ')' });
                            string[] pixelLineData = lineData[0].Split(',');

                            int _lineNumber = Convert.ToInt32(pixelLineData[0]);
                            int _startPixel = Convert.ToInt32(pixelLineData[1]);
                            //trim spaces from data
                            lineData[1] = lineData[1].Trim();
                            //trim off last comma
                            lineData[1] = lineData[1].Substring(0, lineData[1].Length - 1);

                            //split color codes
                            string[] _helperString = lineData[1].Split(',');
                            int[] _colorCodes = new int[_helperString.Length];

                            //convert color codes to colors using palette and put into the appropriate line
                            for (int i = 0; i < _helperString.Length; i++)
                            {
                                int number = Convert.ToInt32(_helperString[i]);
                                Color c = Palette[number];
                                pixelData[_lineNumber].AddPixelData(c, i + _startPixel);
                            }
                        }                                             
                    }
                }
                return pixelData;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return pixelData;
            }
        }

        private Color[] GetPalette(string PaletteLocation)
        {
            Color[] _palette = new Color[256];
            try
            {
                using (StreamReader sr = new StreamReader(PaletteLocation))
                {
                    while(!sr.EndOfStream)
                    {
                        string data = sr.ReadLine();
                        if (data != "")
                        {
                            data = data.Trim();
                            string[] lineData = data.Split(':');

                            //find line number
                            lineData[0] = lineData[0].Trim(new char[] { '(', ')' });
                            string[] lineNumber = lineData[0].Split(',');

                            //parse color RGB
                            lineData[1] = lineData[1].Trim();

                            string[] parseHelper = lineData[1].Split(',');

                            int[] RGB = { 255, 255, 255 };
                            for (int i = 0; i < 3; i++)
                            {
                                RGB[i] = Convert.ToInt32(parseHelper[i]);
                            }

                            Color c = Color.FromArgb(RGB[0], RGB[1], RGB[2]);
                            _palette[Convert.ToInt32(lineNumber[0])] = c;
                        }                        
                    }
                }
                return _palette;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return _palette;
            }
        }
    }
}
