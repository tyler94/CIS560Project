using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace MovieTheaterApplication
{
    public partial class ActiveMoviesForm : Form
    {
        public ActiveMoviesForm()
        {
            InitializeComponent();
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void uxAddMovie_Click(object sender, EventArgs e)
        {
            new Thread(() => new AddMovieForm().ShowDialog()).Start();
        }

        private void uxModifyMovieButton_Click(object sender, EventArgs e)
        {
            new Thread(() => new ModifyMovieForm().ShowDialog()).Start();
        }
    }
}
