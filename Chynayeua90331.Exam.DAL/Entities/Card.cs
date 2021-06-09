namespace Chynayeua90331.Exam.DAL.Entities
{
    public class Card
    {
        public int CardId { get; set; } // id блюда
        public string Eng { get; set; } // название блюда
        public string Rus { get; set; } // описание блюда
        public string Description { get; set; } // кол. калорий на порцию
        public string Image { get; set; } // имя файла изображения 
    }
}
