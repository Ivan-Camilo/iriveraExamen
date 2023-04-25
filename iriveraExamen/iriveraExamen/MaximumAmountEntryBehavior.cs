using System;
using Xamarin.Forms;

namespace iriveraExamen
{
	public class MaximumAmountEntryBehavior
	{
        public int MaximumAmount { get; set; } = 10;

        public MaximumAmountEntryBehavior()
        {
            AdditionalCheck = (e, ot) =>
            {
                e.Text = Convert.ToDouble(e.Text) > MaximumAmount ? ot : e.Text.ToString();
            };
        }
        protected override void OnAttachedTo(BindableObject bindable)
        {
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(BindableObject bindable)
        {
            base.OnDetachingFrom(bindable);
        }

        protected override void TextChanged_Handler(object sender, TextChangedEventArgs e)
        {
            base.TextChanged_Handler(sender, e);
        }
    }
}

