using CollectionTracking.Business.Abstract;
using CollectionTracking.Business.DependencyResolvers.Ninject;
using CollectionTracking.Entities.Concrete;
using System;
using System.Windows.Forms;

namespace CollectionTracking.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _filmService = InstanceFactory.GetInstance<IFilmService>();
        }

        private IFilmService _filmService;

        private void LoadFilms()
        {
            dgwFilm.DataSource = _filmService.GetAll();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            LoadFilms();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (dtpPublishDate.Value == null)
                {
                    dtpPublishDate.Value = DateTime.Now;
                }
                _filmService.Add(new Film
                {
                    Name = tbxFilmName.Text,
                    Type = tbxType.Text,
                    PublishDate = dtpPublishDate.Value
                });
                MessageBox.Show("Film eklendi");
                LoadFilms();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwFilm.CurrentRow != null)
                {
                    if (dtpPublishDate.Value == null)
                    {
                        dtpPublishDate.Value = DateTime.Now;
                    }
                    _filmService.Update(new Film
                    {
                        Id = Convert.ToInt32(dgwFilm.CurrentRow.Cells[0].Value),
                        Name = tbxFilmNameUpdate.Text,
                        Type = tbxTypeUpdate.Text,
                        PublishDate = dtpPublishDateUpdate.Value
                    });
                    MessageBox.Show("Film güncellendi");
                    LoadFilms();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwFilm.CurrentRow;
            tbxFilmNameUpdate.Text = row.Cells[1].Value.ToString();
            tbxTypeUpdate.Text = row.Cells[2].Value.ToString();
            dtpPublishDateUpdate.Value = Convert.ToDateTime(row.Cells[3].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwFilm.CurrentRow != null)
            {
                try
                {
                    _filmService.Delete(new Film { Id = Convert.ToInt32(dgwFilm.CurrentRow.Cells[0].Value) });
                    MessageBox.Show("Film silindi");
                    LoadFilms();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
