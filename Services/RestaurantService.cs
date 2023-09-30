using ShoppingCenterApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenterApp.Services {
    public class RestaurantService {
        public List<Establishment> GetAll() {
            //return new List<Establishment>();
            return RestaurantMockService();
        }

        public static List<Establishment> RestaurantMockService() {
            return new List<Establishment>() {
                new Establishment() {
                    Id = 1,
                    Name = "Burguer King",
                    Description = "Burger King, muitas vezes abreviado como BK, é uma rede de restaurantes especializada em fast-food, fundada nos Estados Unidos por James McLamore e David Edgerton, que abriram a primeira unidade em Miami, Flórida.",
                    CoverImage = "https://mercadoeconsumo.com.br/wp-content/uploads/2022/03/shutterstock_502429909-scaled.jpg",
                    LogoImage = "https://cdn.cookielaw.org/logos/178e65db-f98c-4c7c-8f4b-8636690f283f/f9a6658e-932d-4d19-8edb-a9c6624d5c0e/162d5781-e9e7-4d76-8f49-f0ee0820080c/novo-logo-burger-king-2021.png",
                    Phone = "(11) 3003-5464",
                    Location = "Praça de alimentação, 2º Piso",
                    Type = Models.Enums.EstablishmentType.Restaurant
                },
                new Establishment() {
                    Id = 2,
                    Name = "McDonald's",
                    Description = "McDonald's Corporation é uma rede multinacional estadunidense de fast food, fundada em 1940 como um restaurante operado por Richard e Maurice McDonald, em San Bernardino, Califórnia, Estados Unidos. Eles rebatizaram seu negócio como uma barraca hambúrguer e mais tarde transformaram a empresa em uma franquia, com o logotipo Arcos Dourados sendo introduzido em 1953 em uma unidade em Phoenix, Arizona ",
                    CoverImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/New-McDonald-HU-lg_%2843261171540%29.jpg/1024px-New-McDonald-HU-lg_%2843261171540%29.jpg",
                    LogoImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/McDonald%27s_Golden_Arches.svg/800px-McDonald%27s_Golden_Arches.svg.png",
                    Phone = "(11) 3230-3223",
                    Location = "Praça de alimentação, 2º Piso",
                    Type = Models.Enums.EstablishmentType.Restaurant
                },
                new Establishment() {
                    Id = 3,
                    Name = "Bobs",
                    Description = "Bob's é uma rede brasileira de restaurantes foodservice fundada em 1952, pelo jogador de tênis estadunidense-brasileiro Robert Falkenburg, campeão do torneio de Wimbledon em 1948 e 1949.",
                    CoverImage = "https://www.franquiaz.com.br/wp-content/uploads/2018/08/franquia-bobs.jpg",
                    LogoImage = "https://upload.wikimedia.org/wikipedia/pt/6/66/Logo_bobs.png",
                    Phone = "(37) 98825-5305",
                    Location = "Praça de alimentação, 2º Piso",
                    Type = Models.Enums.EstablishmentType.Restaurant
                },
                new Establishment() {
                    Id = 4,
                    Name = "Subway",
                    Description = "Subway é uma rede norte-americana de restaurantes fast food, com especialidade em vendas de sanduíches e saladas. Foi fundada em 1965 por Fred De Luca e Peter Buck. É considerada a rede de franquias que cresceu mais depressa no mundo, com mais de 44 mil restaurantes espalhados por 98 países. Está entre as 3 maiores cadeias de restaurantes do mundo",
                    CoverImage = "https://mercadoeconsumo.com.br/wp-content/uploads/2017/01/franquia-subway-1024x682.jpg",
                    LogoImage = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/5c/Subway_2016_logo.svg/1920px-Subway_2016_logo.svg.png",
                    Phone = "(37) 3112-2277",
                    Location = "Praça de alimentação, 2º Piso",
                    Type = Models.Enums.EstablishmentType.Restaurant
                },
                new Establishment() {
                    Id = 5,
                    Name = "Spoleto",
                    Description = "O Spoleto é uma rede de restaurantes brasileira de fast casual inspirada na culinária italiana. O nome é uma homenagem à cidade de Spoleto, localizada na região de Úmbria na Itália e remete a ideia de descontração.",
                    CoverImage = "https://1.bp.blogspot.com/-12-308lkMCc/XvqskFmgkMI/AAAAAAABzFI/PTdLUALEVqg5aNLB-OTlOnNBeDrwbh7wACLcBGAsYHQ/s1600/spoleto%2B1.jpg",
                    LogoImage = "https://upload.wikimedia.org/wikipedia/pt/8/80/Spoleto_logo.png",
                    Phone = "(37) 99807-1614",
                    Location = "Praça de alimentação, 2º Piso",
                    Type = Models.Enums.EstablishmentType.Restaurant
                }
            };
        }
    }
}
