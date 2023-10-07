using POO.ContentContext;
using POO.NotificationContext;

namespace POO.SubscriptionContext
{
    internal class Stundent : Base
    {
        public Stundent()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremiun)
            {
                AddNotification(new Notification("Premium", "O aluno já é assinante premiun"));
                return;
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremiun => Subscriptions.Any(x => !x.IsInactive);
    }
}
