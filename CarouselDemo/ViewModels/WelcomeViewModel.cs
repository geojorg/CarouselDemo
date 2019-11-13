using CarouselDemo.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarouselDemo.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        readonly IList<Carousel> source;

        public ObservableCollection<Carousel> Carousels { get; private set; }

        public WelcomeViewModel()
        {
            source = new List<Carousel>();
            CreateCarouselCollection();
        }

        private void CreateCarouselCollection()
        {
            source.Add(new Carousel
            {
                Icon = "carousel0",
                Header = "Happy Bird 1",
                Body = "I need to go to Work NOW"
            });
            source.Add(new Carousel
            {
                Icon = "carousel1",
                Header = "Happy Bird 2",
                Body = "Should I go to the laundry or the super market?"
            });
            source.Add(new Carousel
            {
                Icon = "carousel2",
                Header = "Not so Happy Bird 3",
                Body = "Shh%$#& I need to clean the kitchen."
            });
            Carousels = new ObservableCollection<Carousel>(source);
        }
    }
}
