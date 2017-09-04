using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace h5dataToGIF
{
    class PixelLine
    {
        private Color[] _pixelLine;
        private int _pixelCount;

        public int PixelCount
        {
            get { return _pixelCount; }
        }

        public Color[] LineData
        {
            get { return _pixelLine; }
        }

        public PixelLine(int PixelCount)
        {
            _pixelLine = new Color[PixelCount];
            this._pixelCount = PixelCount;
        }

        public void AddPixelData(Color PixelColor, int PixelNumber)
        {
            if (PixelNumber < PixelCount)
            {
                _pixelLine[PixelNumber] = PixelColor;
            }
            else
            {
                throw new Exception("PixelNumer larger than max pixel count");
            }
        }
    }
}
