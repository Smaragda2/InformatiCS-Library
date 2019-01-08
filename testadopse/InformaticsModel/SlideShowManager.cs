using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SlideShow
{
    class SlideShowManager
    {
        private PictureBox image_displayer;
        private String[] paths;
        private int index_of_currently_displayed_picture;
        
        //Constructor
        public SlideShowManager(PictureBox p, String[] pathss)
   {
       this.image_displayer = p;
       this.paths = pathss;
       display(0);
   }
        //get-set
        public String[] Paths
        {
            get
            {
                return paths;
            }
            set
            {
                paths = value;
            }
        }
        public PictureBox Image_displayer {

            get
            {
                return image_displayer;
            }
            set
            {
                 image_displayer = value;
            }
        
        }

        private void display(int index){
            if (index > -1 && index < paths.Length)
            {
                index_of_currently_displayed_picture = index;
                image_displayer.ImageLocation = paths[index_of_currently_displayed_picture];
                image_displayer.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        public void left(){
            index_of_currently_displayed_picture -= 1;
            if (index_of_currently_displayed_picture == -1) {
                index_of_currently_displayed_picture = paths.Length-1;
            }
            display(index_of_currently_displayed_picture);
        
        }
        public void right() {
            index_of_currently_displayed_picture = index_of_currently_displayed_picture+1;
            if (index_of_currently_displayed_picture == paths.Length)
            {
                index_of_currently_displayed_picture = 0;
            }
            display(index_of_currently_displayed_picture);
        
        }
      
        
       
    }
}
