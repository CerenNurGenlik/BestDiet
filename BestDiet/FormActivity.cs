using BusinessLogicLayer.Services;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiet
{
    public partial class FormActivity : Form
    {
        Exercise exercise;
        ExerciseDetail exerciseDetail;
        ExerciseDetailService exerciseDetailService;
        SportService sportService;
        List<Sport> sportList;
        List<ExerciseDetail> exerciseDetails;


        public FormActivity(Exercise _exercise)
        {
            InitializeComponent();
            exercise = _exercise;
            sportService = new SportService();
        }

        private void FormActivity_Load(object sender, EventArgs e)
        {
            Helper.ClearControls(Controls);
            sportList = sportService.GetSports();
            exerciseDetails = exerciseDetailService.GetSportsByExercise(exercise.UserID, exercise.ExerciseDate);
            ListActivities();
            ListAddedActivities();
        }

        void ListActivities()
        {
            lvAktiviteler.Items.Clear();
            ListViewItem lvitem;
            foreach (Sport item in sportList)
            {
                lvitem = new ListViewItem();
                lvitem.Text = item.SportName;
                lvitem.SubItems.Add(item.BurningCalori.ToString());
                lvitem.Tag = item.SportID;
                lvAktiviteler.Items.Add(lvitem);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sportID = (int)lvAktiviteler.SelectedItems[0].Tag;
            Sport sport = sportService.GetBySportID(sportID);

            try
            {
                exerciseDetail = new ExerciseDetail();
                exerciseDetail.ExerciseID = exercise.ExerciseID;
                exerciseDetail.SportID = sportID;
                exerciseDetail.BurningCalori = sport.BurningCalori;
                exerciseDetail.Exercise.ExerciseDate = dtpOgunTarihi.Value;

                if (exerciseDetailService.Insert(exerciseDetail))
                {
                    exerciseDetails.Add(exerciseDetail);
                    MessageBox.Show("Egzersiz eklendi");
                }
                else throw new Exception("Ekleme sırasında hata oluştu");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ListAddedActivities()
        {
            lvEklenenAktiviteler.Items.Clear();
            ListViewItem lvitem;
            foreach (ExerciseDetail item in exerciseDetails)
            {
                lvitem = new ListViewItem();
                lvitem.Text = exerciseDetail.Sport.SportName;
                lvitem.SubItems.Add(item.BurningCalori.ToString());
                lvitem.Tag = item.ExerciseDetailID;
                lvEklenenAktiviteler.Items.Add(lvitem);
            }
        }

        private void btnAktiviteEkle_Click(object sender, EventArgs e)
        {
            FormActivityAdd formActivityAdd = new FormActivityAdd();
            formActivityAdd.ShowDialog();
        }
    }
}
