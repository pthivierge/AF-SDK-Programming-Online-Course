/***************************************************************************
   Copyright 2017 OSIsoft, LLC.
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at
       http://www.apache.org/licenses/LICENSE-2.0
   
   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 ***************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OSIsoft.AF.Asset;

namespace Exercise2_Solution
{
    public partial class AttributesForm : Form
    {
        private AFElement Element { get; }

        public AttributesForm(AFElement element)
        {
            Element = element;
            InitializeComponent();

            if (element != null)
            {
                lblElement.Text = element.GetPath(element.Database);
                afViewControl1.AFSetObject(element, null, null, null);
                // This should just to "Attributes" tab.
                afViewControl1.AFSelection = element.Attributes;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AttributesForm_Resize(object sender, EventArgs e)
        {
            btnClose.Left = (Width - btnClose.Width) / 2;
        }
    }
}
