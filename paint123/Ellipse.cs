﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint123
{
    class Ellipse : Instrument
    {
        public override void Draw(Graphics g, Point currentPoint)
        {
            if (StartPoint is not null)
            {
                //g.DrawImage(CurrentImage, 0, 0);
                if ((bool)fill)
                {
                    g.FillEllipse(Brush, GetRectangle((Point)StartPoint, currentPoint));
                }
                g.DrawEllipse(Pen, GetRectangle((Point)StartPoint, currentPoint));
            }
        }
    }
}
