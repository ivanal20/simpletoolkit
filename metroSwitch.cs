using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpletoolkit
{
    public partial class metroSwitch : UserControl
    {
        public metroSwitch()
        {
            InitializeComponent();
        }
        public bool Checked { get; set; }
        Image img()
        {
            Checked = !Checked;
            if (Checked)
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAAAXNSR0IArs4c6QAAAARzQklUCAgICHwIZIgAAAJjSURBVEiJ7dZNaNNgHMfxX56lTZp0bXxrEV/Wjg48eHAM6lCEzYsoHgoOwTmQXXb2oILioaC4uwcPQ9CDA3uQ9SA4QaxjIlLYBLfDwLGujqJpR5dkadL0LR7EsTrptqcgKP0ek/+TTyDwPAFatfrfYhrdjNx91ccwtk378Il7F6Z2DA+NTo9Ie7yXBEE44XQ6fLQoAJiGuWqVSrPKmvri2e0zY3+EI9GEtM8rTgQCR/t4nm/G21KxWMTKSmYym9euxKP9ygYciSakgz7pdWcwGKZ9OMcCp0I8Qn4HvC4CAPgilzGbtrCSrwIAllKp5Lesci4e7VdYADggCU+aQX3tBJfDbvCO+i/X5Xegy+/AfKaEyTkTncFg2LaXHgEYbLv6IHHx0OEjt3ied9KgHheDwd72LWjdi3nawLEMllcrIAwJdpwceE/cojsiSV43DQoAZ4+5GqK/6glw8LgYSJLXLXLcNeL2eI7TohwLhPyOHc/3dHAAAF4QuolhFPy0sM/TRjVfKll7CS3abEQQRJl2cVarUs07nVye6Jo2TwtbFWBRLu94fiZtAQCKhvGJ6AU9riqqTou/XTBhlbffzmeWLWimDVVR9apdfUjG7/S/lOXvb2hhzbQRS+oN8flMCYmFIgAgl83GHl/v/UwAIKcYw0upVJIWz67XMDal4cNiEapZ27i+KJcRS+qYnDMB/Nwy5TX9BvAXD4mv6XQ8pxjDdYfE5oZGp0ckqX2A4/hul+DaL4oiWJbdFVSpVFAoFGAa5mqtWvm4pqjjT2+efr55ZtsfgV2JvxW/f/5dM+tbtfq3+gFAC+m60FNE3wAAAABJRU5ErkJggg==")));
            }
            else 
            {
                return Image.FromStream(new MemoryStream(Convert.FromBase64String("iVBORw0KGgoAAAANSUhEUgAAAB4AAAAeCAYAAAA7MK6iAAAAAXNSR0IArs4c6QAAAARzQklUCAgICHwIZIgAAAJjSURBVEiJ7dZNaNNgHMfxX56lTZp0bXxrEV/Wjg48eHAM6lCEzYsoHgoOwTmQXXb2oILioaC4uwcPQ9CDA3uQ9SA4QaxjIlLYBLfDwLGujqJpR5dkadL0LR7EsTrptqcgKP0ek/+TTyDwPAFatfrfYhrdjNx91ccwtk378Il7F6Z2DA+NTo9Ie7yXBEE44XQ6fLQoAJiGuWqVSrPKmvri2e0zY3+EI9GEtM8rTgQCR/t4nm/G21KxWMTKSmYym9euxKP9ygYciSakgz7pdWcwGKZ9OMcCp0I8Qn4HvC4CAPgilzGbtrCSrwIAllKp5Lesci4e7VdYADggCU+aQX3tBJfDbvCO+i/X5Xegy+/AfKaEyTkTncFg2LaXHgEYbLv6IHHx0OEjt3ied9KgHheDwd72LWjdi3nawLEMllcrIAwJdpwceE/cojsiSV43DQoAZ4+5GqK/6glw8LgYSJLXLXLcNeL2eI7TohwLhPyOHc/3dHAAAF4QuolhFPy0sM/TRjVfKll7CS3abEQQRJl2cVarUs07nVye6Jo2TwtbFWBRLu94fiZtAQCKhvGJ6AU9riqqTou/XTBhlbffzmeWLWimDVVR9apdfUjG7/S/lOXvb2hhzbQRS+oN8flMCYmFIgAgl83GHl/v/UwAIKcYw0upVJIWz67XMDal4cNiEapZ27i+KJcRS+qYnDMB/Nwy5TX9BvAXD4mv6XQ8pxjDdYfE5oZGp0ckqX2A4/hul+DaL4oiWJbdFVSpVFAoFGAa5mqtWvm4pqjjT2+efr55ZtsfgV2JvxW/f/5dM+tbtfq3+gFAC+m60FNE3wAAAABJRU5ErkJggg==")));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            pictureBox1.Image = img();
        }

        private void metroSwitch_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = img();
        }
    }
}
