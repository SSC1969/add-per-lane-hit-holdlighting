﻿using System;
using System.Drawing;
using Quaver.Graphics.Base;
using Quaver.Graphics.Colors;
using Quaver.Graphics.Enums;
using Quaver.Graphics.Text;
using Quaver.Graphics.UniversalDim;
using Quaver.Graphics.UserInterface;
using Quaver.Main;
using Color = Microsoft.Xna.Framework.Color;

namespace Quaver.States.Gameplay.UI
{
    internal class SongTimeProgressBar : ProgressBar
    {
        /// <summary>
        ///     The display for the current time.
        /// </summary>
        private NumberDisplay CurrentTime { get; }

        /// <summary>
        ///     The display for the time left.
        /// </summary>
        private NumberDisplay TimeLeft { get; }

        /// <inheritdoc />
        /// <summary>
        ///     Ctor - 
        /// </summary>
        /// <param name="maxValue"></param>
        /// <param name="initialValue"></param>
        /// <param name="size"></param>
        /// <param name="parent"></param>
        /// <param name="alignment"></param>
        internal SongTimeProgressBar(float maxValue, float initialValue, UDim2D size, Drawable parent, Alignment alignment) 
            : base(maxValue, initialValue, size, parent, alignment)
        {
            CurrentTime = new NumberDisplay(NumberDisplayType.SongTime, "00:00")
            {
                Parent = this,
                Alignment = Alignment.TopLeft,     
                PosY = -SizeY - 25,
                PosX = 10
            };

            TimeLeft = new NumberDisplay(NumberDisplayType.SongTime, "-00:00")
            {
                Parent = this,
                Alignment = Alignment.TopRight,
                PosY = CurrentTime.PosY
            };

            TimeLeft.PosX = -TimeLeft.TotalWidth - 10;
        }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="dt"></param>
        internal override void Update(double dt)
        {
            // Set the time of the current time
            if (CurrentValue > 0)
            {
                var currTime = new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds((int) CurrentValue);
                CurrentTime.Value = currTime.ToString("mm:ss");
            }
            
            // Set the time of the time left.
            if (MaxValue - CurrentValue >= 0)
            {
                var timeLeft = new DateTime(1970, 1, 1) + TimeSpan.FromMilliseconds((int) (MaxValue - CurrentValue));
                
                // Get the old value.
                var oldValue = TimeLeft.Value;
                
                // Set the new value.
                TimeLeft.Value = "-" + timeLeft.ToString("mm:ss");
                
                // Check if we need to reposition it since it's on the right side of the screen.
                if (oldValue.Length != TimeLeft.Value.Length)
                    TimeLeft.PosX = -TimeLeft.TotalWidth - 10;
            }
            
            base.Update(dt);
        }
    }
}