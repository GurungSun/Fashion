using System;
using FashionP.Models;

namespace FashionP.Data;

public class CultureData
{ 
    public List<Culture> Cultures = new List<Culture>
    {
        new Culture(
            Guid.NewGuid(),
            "Japanese Fashion",
            "Japanese fashion blends centuries-old tradition with cutting-edge modern style, creating a unique balance of elegance and experimentation. Classic garments like the kimono, yukata, and finely crafted textiles showcase deep cultural heritage, while contemporary street styles—from Harajuku’s playful looks to minimalist designer fashion—highlight bold self-expression. Together, they reflect a culture that values precision, creativity, and the harmony between old and new.",
            "https://www.ana.co.jp/japan-travel-planner/feature/japanese-festival-omatsuri/0000001/002.jpg"
        ),
        new Culture(
            Guid.NewGuid(),
            "French Culture",
            "French fashion is renowned for its effortless sophistication, combining timeless wardrobe staples with a “less is more” approach to style. Parisian influence runs deep, from everyday chic—featuring tailored silhouettes, neutral palettes, and high-quality fabrics—to haute couture houses like Chanel and Dior that set worldwide trends. This blend of refinement, artistry, and subtle glamour defines France’s enduring place in global fashion culture.",
            "https://leoncechenal.com/wp-content/uploads/2023/01/best_french_clothing_brands_for_men.webp"
        ),
        new Culture(
            Guid.NewGuid(),
            "Nigerian Fashion",
            "Nigerian fashion is dynamic and culturally rich, celebrated for its powerful use of color, bold patterns, and diverse traditional garments. Fabrics such as ankara, aso-oke, adire, and lace are crafted into expressive outfits like agbada, buba, kaftans, and gele headwraps, often worn for major ceremonies and celebrations. Modern designers blend these traditions with contemporary cuts and global trends, showcasing a fashion culture rooted in identity, pride, and vibrant creativity.",
            "https://ichef.bbci.co.uk/ace/standard/976/cpsprodpb/2e88/live/958ffa00-4526-11f0-bace-e1270fc31f5e.jpg"
        )
    };

}
