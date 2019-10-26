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
                        ImageThumbnailUrl = "https://nb.scene7.com/is/image/NB/m9919ec_nb_03_i?$pdpThumbPict2x$&extend=10,10,10,10&fmt=webp"
                    },

                    new Sneaker
                    {
                        Name = "Nike Air Max 270 React ‘Bauhaus’",
                        Price = 139,
                        ShortDescription = "Air Max 270",
                        LongDescription = "Nike’s Air Max 270 was an instant hit when it first emerged last year but it’s futuristic look wasn’t for everyone and die-hard sneakerheads, in particular, have struggled to get onboard. That all changed this summer with the release of the Air Max 270 React. The addition of an ultra-springy React sole and two retro-inspired ‘Bauhaus’ colourways have opened the 270 up to a more discerning audience. One of the best colour palettes we’ve seen in 2019, for sure.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://media.endclothing.com/media/catalog/product/1/9/19-06-2019_nike_airmax270react_phantomgolduniversityred_ao4971-002_aj_1.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://reede.ee/media/catalog/product/cache/4/thumbnail/9df78eab33525d08d6e5fb8d27136e95/n/i/nike-air-max-270-react-bauhaus-1.jpg"
                    },

                    new Sneaker
                    {
                        Name = "Novesta Star Master Orange",
                        Price = 59,
                        ShortDescription = "Hardly new brand but some colour inovations",
                        LongDescription = "The existence of Novesta’s canvas Star Master pump is hardly breaking news in the world of footwear. What is new, however, is a fresh crop of summer-friendly colourways, perfect for brightening up beer gardens while the nice weather lasts. Orange has been trending hard for some time now and it’s still a solid option for adding a dash of personality to proceedings.So strap into a pair of these bad boys, teamed with white socks, shorts and a Cuban collar shirt, and tackle BBQ season the right way.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://www.gonovesta.com/obrazok/star-master-84-orange-1.jpg?imageId=9929",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/1008/8852/products/VN0A38EMUKU-2_large.jpg?v=1557855852"
                    },


                    new Sneaker
                    {
                        Name = "Nike Tailwind '79",
                        Price = 80,
                        ShortDescription = "Sneakers rarely come with more historical clout than Nike’s Tailwind ‘79. ",
                        LongDescription = "Originally released for the Honolulu Marathon in – oh – 1978 (think of this as the sequel), the retro beauty was the first Nike model to feature the label’s now-famous ‘Air’ cushioning technology. Today, it’s hardly at the cutting edge of tech. It is, however, still at the cutting edge of looking really good with shorts, which is why we were so pleased to be blessed with a plethora of new vibrant colourways this season.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://static.fashionbeans.com/wp-content/uploads/2019/07/summersneaker-19-4.jpg",
                        InStock = true,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://c.static-nike.com/a/images/t_PDP_144_v1/f_auto/zdzjlme0ddovgbsock5t/air-tailwind-79-shoe-PNXmkq.jpg"


                    },

                    new Sneaker
                    {
                        Name = "Nike x Sacai LD Waffle",
                        Price = 355,
                        ShortDescription = " Nike and Sacai’s LD Waffle was unimaginably difficult to cop, yet it seems everyone is rocking a pair.",
                        LongDescription = "This OTT sneaker mashup from the Oregonian sportswear giant and Japanese fashion renegade is truly inescapable. Thanks to a delayed release, this tricked-out kick became the most hyped shoe of 2019 and with more colourways in the pipeline, things don’t seem to be settling down anytime soon.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://static.fashionbeans.com/wp-content/uploads/2019/07/summersneaker-19-9.jpg",
                        InStock = true,
                        IsPreferred = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQqOrS2LiUo91rJwk0wT47Mw-GCJ6JxOHJ5JGL54S0tmpUev19&s"


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
                        ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/813y2OVs-HL._AC_UL160_.jpg"

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
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRxHiu5IBmq_8aXJdisb9Gd5Ps9_sOiuNUznZxU2KybfCksNpBmtA&s"
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
                        ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/61nvhJD2lpL._AC_UL160_.jpg"
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
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrBwOM9A3odE3UpEFM9CkkMPuq1jFk8TeErLRYniw1-9siPc3O&s"

                    },


                    new Sneaker
                    {
                        Name = "The North Face Tsumoru Boot",
                        Price = 125,
                        ShortDescription = "Best Warmth for the Money",
                        LongDescription = "Sometimes it’s hard to get your head wrapped around the product line-up from North Face. They have a line of fashion only wear then they have their tough, outdoor gear. Sometimes it’s hard to know which is which. Luckily, most of their boots fall into that outdoor gear category and are quite good for a budget price.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81UTKwdmdlL._SL600_.jpg",
                        InStock = false,
                        IsPreferred = true,
                        ImageThumbnailUrl = "https://4.bp.blogspot.com/-E6s3W0I3cT0/Wm1RinTK4rI/AAAAAAAAbRE/dhfR4Nhod74dtTvP6YbiEtVyh4h5S72rACLcBGAs/s640/P1250288.jpg"
                    }


                    





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
