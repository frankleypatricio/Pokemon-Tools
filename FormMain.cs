﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokémon_Tools {
    public partial class form_main : Form {
        private form_weeks weeks;
        private form_weeksList weeksList;
        public form_main() {
            InitializeComponent();
            weeks=new form_weeks();
            weeksList=new form_weeksList();
            weeks.Show();
            weeksList.Show();
        }
    }
}
