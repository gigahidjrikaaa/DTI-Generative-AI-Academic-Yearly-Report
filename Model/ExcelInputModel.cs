using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTI_Generative_AI_Academic_Yearly_Report.Model
{
    class ExcelInputModel
    {
        private int id;
        private string name;
        private string description;
        private DateTime uploadedAt;
        private DateTime updatedAt;
        public string author;
        public string[] coAuthor;
        public string[] tags;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime UploadedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Author { get; set; }
        public string[] CoAuthor { get; set; }
        public string[] Tags { get; set; }

        public ExcelInputModel()
        {
            Console.WriteLine("Excel Input Loaded");
        }

    }
}
