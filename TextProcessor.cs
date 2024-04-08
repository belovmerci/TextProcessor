using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextProcessor
{
    public partial class TextProcessor : Form
    {
        int deleteAbove = 0;

        public TextProcessor()
        {
            InitializeComponent();
        }

        private void deletePunctuationCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DeleteAboveTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
