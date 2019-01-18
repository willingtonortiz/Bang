using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel.Design;

namespace Bang.custom_controls
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class BanCharacter : UserControl
    {
        public BanCharacter()
        {
            InitializeComponent();
            InitializeVisual();
            InitializeData();
        }

        private void InitializeVisual()
        {
            imageCharacter.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter.SizeMode = PictureBoxSizeMode.StretchImage;

            imageLife.Image = Image.FromFile("../../assets/life.png");
            imageLife.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageArrow.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrow.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void InitializeData()
        {
            labelLife.Text = "Hola";
            labelArrow.Text = "Hola";
        }
    }
}
