using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bang.custom_controls
{
    public class DieButton : Button
    {
        private bool IsSelected { get; set; }

        public DieButton()
        {
            this.IsSelected = true;
            this.Click += DieButton_Click;
            this.FlatAppearance.BorderColor = Color.Gray;
        }

        private void DieButton_Click(object sender, EventArgs e)
        {
            IsSelected = !IsSelected;
            if (IsSelected)
            {
                this.FlatAppearance.BorderColor = Color.Yellow;
            }
            else
            {
                this.FlatAppearance.BorderColor = Color.Gray;
            }
        }
    }
}
