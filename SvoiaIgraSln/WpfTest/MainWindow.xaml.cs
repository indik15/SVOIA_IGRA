using System.Windows;
using System.Windows.Controls;

namespace WpfTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Create_Click(object sender, RoutedEventArgs e)
        {
            NEW nEW = new NEW();
            MainContent.Content = nEW;
            LOL1.Visibility= Visibility.Collapsed;
        }
    }
}




























/*         using (ApplicationContext db = new ApplicationContext())
                 {

                     QuestionModelClass question1 = new QuestionModelClass { Id = 1, Questions = "Чтобы снять огромный стресс,Купил себе я …", CorrectAnswer = " Мерседес" };
         QuestionModelClass question2 = new QuestionModelClass { Id = 2, Questions = "На многое горазда Новенькая …", CorrectAnswer = "Мазда" };
         QuestionModelClass question3 = new QuestionModelClass { Id = 3, Questions = "Не хочешь, чтобы обогнали,Садись быстрей за руль …", CorrectAnswer = "Феррари" };
         QuestionModelClass question4 = new QuestionModelClass { Id = 4, Questions = "Надежна она и игрива. Зовут ее Машина…", CorrectAnswer = "Нива" };
         QuestionModelClass question5 = new QuestionModelClass { Id = 5, Questions = "Хочешь выделиться? Как?Тебе нужен …", CorrectAnswer = "Кадилак" };
         QuestionModelClass question6 = new QuestionModelClass { Id = 6, Questions = "В этой стране самое большое количество овец на душу населения.", CorrectAnswer = "Великобритания" };
         QuestionModelClass question7 = new QuestionModelClass { Id = 7, Questions = "Назовите страну с самым большим количеством озёр в мире.", CorrectAnswer = "Канада" };
         QuestionModelClass question8 = new QuestionModelClass { Id = 8, Questions = "Назовите самую засушливую страну в мире.", CorrectAnswer = "Ливия" };
         QuestionModelClass question9 = new QuestionModelClass { Id = 9, Questions = "В состав этого государства входят около 2000 островов, на которые приходится почти 20% всей площади страны.", CorrectAnswer = "Греция" };
         QuestionModelClass question10 = new QuestionModelClass { Id = 10, Questions = "В 1983 году в этой стране не родилось ни одного человека.", CorrectAnswer = "Ватикан" };

         /*db.Add(question1);
         db.Add(question2);
         db.Add(question3);
         db.Add(question4);
         db.Add(question5);
         db.Add(question6);
         db.Add(question7);
         db.Add(question8);
         db.Add(question9);
         db.Add(question10);

         db.SaveChanges();

     }
             }
        */
/* public void Button_Click(object sender, RoutedEventArgs e)
{
    using (ApplicationContext db = new ApplicationContext())
    {               
        var questions = db.QuestionsModels.ToList();

        foreach (QuestionModelClass question in questions)
        {
            MessageBox.Show($"{question.Id} - {question.Questions}");
        }
    }
}*/


