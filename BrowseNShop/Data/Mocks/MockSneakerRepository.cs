using BrowseNShop.Interfaces;
using BrowseNShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowseNShop.Mocks
{
    public class MockSneakerRepository : ISneakerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Sneaker> Sneakers
        {
            get
            {
                return new List<Sneaker>
                {
                    new Sneaker
                    {
                        Name = "New Balance 991.9",
                        Price = 180,
                        ShortDescription = "NB 991.9",
                        LongDescription = "Mixing sole units and uppers from different models has become a sneaker trend for sneaker brands lately. Sadly, it tends to be lazily executed and seldom yields wearable results. Still, now and again there’s an exception to the rule, which this season comes courtesy of Bostonian running and lifestyle legend New Balance.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://nb.scene7.com/is/image/NB/m9919ec_nb_02_i?$pdpPictExp$",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://i8.amplience.net/i/jpl/hp_203202_a?w=175&h=175&qlt=80&w=300&h=300&v=1"
                    },

                    new Sneaker
                    {
                        Name = "Nike Air Max 270 React",
                        Price = 139,
                        ShortDescription = "Air Max 270",
                        LongDescription = "Nike’s Air Max 270 was an instant hit when it first emerged last year but it’s futuristic look wasn’t for everyone and die-hard sneakerheads, in particular, have struggled to get onboard. That all changed this summer with the release of the Air Max 270 React. The addition of an ultra-springy React sole and two retro-inspired ‘Bauhaus’ colourways have opened the 270 up to a more discerning audience. One of the best colour palettes we’ve seen in 2019, for sure.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://media.endclothing.com/media/catalog/product/1/9/19-06-2019_nike_airmax270react_phantomgolduniversityred_ao4971-002_aj_1.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://i.ebayimg.com/images/g/bUAAAOSwX6VdHGb9/s-l300.jpg"
                    },

                    new Sneaker
                    {
                        Name = "Veja V-10",
                        Price = 125,
                        ShortDescription = "Veja V-10 white sneakers",
                        LongDescription = "The minimal V-10 was originally designed to mark the brand’s 10th year but it’s been periodically updated in new colour schemes ever since. This ultra-clean white and black option is our favourite this summer.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://static.fashionbeans.com/wp-content/uploads/2019/07/summersneaker-19-6.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0094/2252/products/V10_Leather_Extra_White_Emeraude_Black_VX021670_2465_300x300.jpg?v=1568028004"
                    },


                    //new Sneaker
                    //{
                    //    Name = "LeBron 3 Houston Oilers",
                    //    Price = 150,
                    //    ShortDescription = "Houston stand up, and grab the LeBron 3 Houston Oilers ",
                    //    LongDescription = "This LBJ 3 comes with a white upper plus blue and red accents, red Nike “Swoosh”, white midsole, and a red sole. These sneakers released in May 2019 and retailed for $175.",
                    //    Category = _categoryRepository.Categories.First(),
                    //    ImageUrl = "https://stockx.imgix.net/Nike-LeBron-3-Houston-Oilers-2019-Suede.png?fit=fill&bg=FFFFFF&w=700&h=500&auto=format,compress&q=90&trim=color&updated_at=1559141442&w=1000",
                    //    InStock = true,
                    //    IsPreferred = true,
                    //    ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS5D48SaARSOp_WE8u8BousPhDDQCzQtqodZzZmOXUnDyOU7Vpxhw&s"


                    //},

                    new Sneaker
                    {
                        Name = "Adidas Alphaedge 4D",
                        Price = 184,
                        ShortDescription = " Adidas 4D sneakers. ",
                        LongDescription = "The latest glimpse came in May courtesy of the Alphaedge 4D, a sleek knitted sports shoe sat atop a springy, geometric, latticed sole unit. This latest 4D release offers performance updates in the form of reinforced stress points, a Continental rubber outsole and an upper that borrows more than a little from the Alphabounce.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://static.fashionbeans.com/wp-content/uploads/2019/07/summersneaker-19-10.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0094/2252/products/White_EF3454_8123_300x300.jpg?v=1568024387"


                    },


                    new Sneaker
                    {
                        Name = "Danner Powderhorn",
                        Price = 215,
                        ShortDescription = "Danner Men's Powderhorn Hunting Shoes",
                        LongDescription = "These boots are meant for hunting the high country and while they have all the insulation you need, they are a little on the heavy side if you are a distance hiker. For those who hunt anywhere but the wettest locations, water will never be an issue. Solid design and solid leather construction.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91zG70PddDL._SL600_.jpg",
                        InStock = false,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/81RbYwVgdpL._AC_UL300_SR300,300_.jpg"

                    },

                    new Sneaker
                    {
                        Name = " Salomon X Ultra Trek GTX",
                        Price = 220,
                        ShortDescription = "Ultralight Winter Boot",
                        LongDescription = "Salomon has gained a huge reputation among those who spend time in bad weather. This is especially true of hikers, backpackers, and mountaineers. A big part of their product line revolves around skiing so they know how to handle cold and wet. This extends into their standard boot lineup.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/91rBIejoR%2BL._SL600_.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://i.ebayimg.com/images/g/YeIAAOSwLuxcpfRT/s-l300.jpg"
                    },


                    new Sneaker
                    {
                        Name = "Merrell Phaserbound 2",
                        Price = 170,
                        ShortDescription = "Most Comfortable Winter Boot",
                        LongDescription = "There should be no doubt that Merrell knows outdoor footwear, maybe better than anyone out there. Though most of their products are more oriented to warm weather activities, some of the boots are designed to be more robust. These make a great winter option that is lightweight and very comfortable.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81%2BKaXWLqLL._SL600_.jpg",
                        InStock = false,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://i.ebayimg.com/images/g/Q7IAAOSw-a1c526q/s-l300.jpg"
                    },


                    new Sneaker
                    {
                        Name = "Sorel Caribou XT",
                        Price = 200,
                        ShortDescription = "Sorel Men's Caribou Extreme Snow Boot",
                        LongDescription = "Sorel is probably best known for its classic styling but this goes far beyond the ‘If it’s not broke don’ fix it’ mentality. The styling may be classic but the construction takes advantage of the best processes and materials available to produce boots that are outstanding quality. Enough so that finding their winter boots when the weather turns cold can be a challenge!",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/71mfGvvsXSL._UL1500_.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://richmedia.channeladvisor.com/ImageDelivery/imageService?profileId=12013292&id=634483&recipeId=380"
                    
                    },

                    //new Sneaker
                    //{
                    //    Name = "The North Face Tsumoru",
                    //    Price = 125,
                    //    ShortDescription = "Best Warmth for the Money",
                    //    LongDescription = "Sometimes it’s hard to get your head wrapped around the product line-up from North Face. They have a line of fashion only wear then they have their tough, outdoor gear. Sometimes it’s hard to know which is which. Luckily, most of their boots fall into that outdoor gear category and are quite good for a budget price.",
                    //    Category = _categoryRepository.Categories.Last(),
                    //    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81UTKwdmdlL._SL600_.jpg",
                    //    InStock = false,
                    //    IsPreferred = true,
                    //    ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYr1ZSzHlIsWOQ8v1Vmoy0DjLPAvlKuD0XSlZ6QfzPxBsn-wF7&s"
                    //}








                };
            }
        }
        public IEnumerable<Sneaker> PreferredSneakers { get; }
        public Sneaker GetSneakerById(int sneakerID)
        {
            throw new NotImplementedException();
        }
    }
}
