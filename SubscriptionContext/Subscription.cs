using POO.ContentContext;

namespace POO.SubscriptionContext
{
    internal class Subscription : Base
    {
        public Plan Plan { get; set; }

        public DateTime? EndData { get; set; }

        public bool IsInactive => EndData <= DateTime.Now;
    }
}
