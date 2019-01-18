using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bang
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            ImageInitialization();
            CharactersLoad();
        }

        private void ImageInitialization()
        {
            // Inicialización de los datos

            /* ===== ARROWS ===== */

            imageArrows.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows1.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows1.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows2.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows2.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows3.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows3.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows4.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows4.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows5.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows5.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows6.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows6.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrows7.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrows7.SizeMode = PictureBoxSizeMode.StretchImage;

            imageArrowsTable.Image = Image.FromFile("../../assets/arrow_die.png");
            imageArrowsTable.SizeMode = PictureBoxSizeMode.StretchImage;

            /* ===== LIFE ===== */

            imageLife.Image = Image.FromFile("../../assets/life.png");
            imageLife.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife1.Image = Image.FromFile("../../assets/life.png");
            imageLife1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife2.Image = Image.FromFile("../../assets/life.png");
            imageLife2.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife3.Image = Image.FromFile("../../assets/life.png");
            imageLife3.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife3.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife4.Image = Image.FromFile("../../assets/life.png");
            imageLife4.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife4.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife5.Image = Image.FromFile("../../assets/life.png");
            imageLife5.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife5.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife6.Image = Image.FromFile("../../assets/life.png");
            imageLife6.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife6.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            imageLife7.Image = Image.FromFile("../../assets/life.png");
            imageLife7.SizeMode = PictureBoxSizeMode.StretchImage;
            imageLife7.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            /* ===== DICE ===== */

            imageDie1.BackgroundImage = Image.FromFile("../../assets/arrow_die.png");

            imageDie2.BackgroundImage = Image.FromFile("../../assets/dynamite_die.png");

            imageDie3.BackgroundImage = Image.FromFile("../../assets/gatling_die.png");

            imageDie4.BackgroundImage = Image.FromFile("../../assets/life_die.png");

            imageDie5.BackgroundImage = Image.FromFile("../../assets/shot_1_die.png");

            imageDie6.BackgroundImage = Image.FromFile("../../assets/shot_2_die.png");

        }

        private void CharactersLoad()
        {
            /* ===== CHARACTER ===== */

            // Personaje actual
            imageCharacter.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            labelName.Text = "Escanor calvo";
            labelHability.Text = "Brillo solar: Lorem ipsum dolor sin amet Lorem ipsum dolor sin amet.\nSol cruel: Lorem ipsum dolor sin amet Lorem ipsum dolor sin amet.";

            imageCharacter1.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter1.SizeMode = PictureBoxSizeMode.StretchImage;

            imageCharacter2.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter2.SizeMode = PictureBoxSizeMode.StretchImage;

            imageCharacter3.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter3.SizeMode = PictureBoxSizeMode.StretchImage;

            imageCharacter4.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter4.SizeMode = PictureBoxSizeMode.StretchImage;

            imageCharacter5.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter5.SizeMode = PictureBoxSizeMode.StretchImage;

            imageCharacter6.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter6.SizeMode = PictureBoxSizeMode.StretchImage;

            imageCharacter7.Image = Image.FromFile("../../assets/escanor_calvo.png");
            imageCharacter7.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LabelInitialization()
        {
            
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // Se inicializan los datos
        }
    }
}
