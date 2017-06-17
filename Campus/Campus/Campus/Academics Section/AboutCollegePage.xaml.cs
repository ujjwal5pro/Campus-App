using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Campus.Academics_Section
{
    public partial class AboutCollegePage : ContentPage
    {
        public AboutCollegePage()
        {
            InitializeComponent();
            //Maincarousel.ItemsSource = image;
            AboutField.Text = "G B Pant Engineering College was established by the Govt.of NCT of Delhi"
                                  +
                                  " in the year 2007 with the aim of imparting quality technical education for the students"
                                  +
                                  " of Delhi and nearby areas.Since its inception, the faculty and staff have been tirelessly"
                                  + " working towards the growth of the institution."
                                  + " Affiliated to Guru Gobind Singh Indraprastha University and approved by AICTE, "
                                  +
                                  " the college started with two batches of students, one each for Mechanical Engineering and"
                                  + " Electronics and Communications Engineering courses.Increasing its horizon in the year"
                                  +
                                  " 2010, a batch of Computer Engineering course was started in the college.With the presence"
                                  +
                                  " of vibrant and dynamic faculty members of highest academic calibre selected by UPSC, G B"
                                  +
                                  " Pant has been able to produce three batches of engineering graduates who have been pursuing"
                                  + " their careers in companies and higher education institutes in India and abroad."
                                  + " The college has been operating from its building in G B Pant Polytechnic campus"
                                  +
                                  " which has been transformed to be equipped with ultra - modern facilities.The college has"
                                  +
                                  " already established various labs for all the branches with up to date modern equipment which"
                                  +
                                  " ensures that the students are trained in the practical realm according to the current industry"
                                  +
                                  " standards.The college is in the process of making its own building with state of the art"
                                  + " facilities.";
            VisionField.Text = "The vision of G B Pant engineering college is to produce a society grounded in technological " +
                               "advancement, social justice and equality by combining knowledge, creativity, ethics and " +
                               "co-operation.";
            MissionField.Text = "The mission of G B Pant govt. engineering college is the advancement of knowledge by educating" +
                                " students in Engineering Sciences, Applied Sciences and Humanities. By following a holistic and" +
                                " inter-disciplinary approach, we believe in producing Engineers who would serve the country and" +
                                " the world in the 21st century.                                                                " +
                                "                                     The eminent faculty of the institute is " +
                                "committed in generating knowledge and disseminating it to the students, thereby nurturing them " +
                                "to become torch bearers of knowledge. By combining academic rigour and excitement of discovery " +
                                "in the subject, the faculty is committed to producing students who would become embodiments of " +
                                "intelligence of both theory and practice. The college is committed to the overall development of" +
                                " the students, making them fine citizens dedicated to the betterment of the society.";
            Aboutcse.Text = "The department of Computer Science Engineering attracts the best students across the country. It offers" +
                           " broad under graduate curriculum based on application and theoretical foundation of computers with the" +
                           "vision to provide excellence and relevance in teaching. It offers intensive exposure to latest technologies" +
                            " including E-commerce, multimedia, data mining, advance computer architecture etc";
            Aboutece.Text = "The strength of the department lies in its faculty, students and research facilities. The well"+
                            " qualified faculty of the institute offers a socially inclusive classroom environment where the"+
                            " students are motivated to learn. The faculty is involved in wide range of research areas "+
                            "encompassing Image Processing, Biomedical signal processing, Microwave and Antenna Design, VLSI"+
                            " Design and Communications. ";
            Aboutmae.Text = "The department offers UG (B.Tech.) program in Mechanical and Automation Engineering. The presence"+
                            " of experienced and highly talented faculty has helped to establish a high reputation for the"+
                            " department in the academia and industry.";
            Abouthas.Text = "The department of Humanities and Applied Sciences is one of the key departments in the Institution"+
                            " as it grooms the students in their first year of study. The department comprises of faculty from"+
                            " four streams including Chemistry, Physics, Mathematics and English (communication skills). "+
                            "The department comprises of highly qualified faculty members and technical staff and well equipped"+
                            " laboratories with advanced instruments. ";
        }

        public int A = 0;
        public int B = 0;
        public int C = 0;
        private void Ondepartmenttapped(object sender, EventArgs e)
        {
            if (A % 2 == 0)
            {
                DFrame.IsVisible = true;
                DLabel.Text = "hide";
            }
            else
            {
                DFrame.IsVisible = false;
                DLabel.Text = "view";
            }
            A++;
        }

    }
}
