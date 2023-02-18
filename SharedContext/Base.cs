using eLearning.NotificationContext;

namespace eLearning.SharedContext
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
