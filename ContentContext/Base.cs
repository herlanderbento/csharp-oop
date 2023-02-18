using eLearning.NotificationContext;

namespace eLearning.ContentContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
