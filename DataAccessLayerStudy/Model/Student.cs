using System.ComponentModel.DataAnnotations;

namespace DataAccessLayerStudy.Model
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string StudentName { get; set; }
        public int Marks { get; set; }

    }
}
