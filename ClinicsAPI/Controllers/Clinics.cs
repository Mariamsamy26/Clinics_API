using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClinicsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Clinics : ControllerBase
    {
        private List<Place> places = new List<Place>
        {
            new Place 
            { 
                Name = "Mariam Clinic",
                Longitude = 31.287078,
                Latitude = 29.932489,
                Phone = "01234567890",
                Rate = 5.0,
                AddressClinic = "قاهره"
            },
            new Place 
            {
                Name = "Dr Ibrahim Abdel Kareem",
                Longitude = 31.3398962,
                Latitude = 30.0588432,
                Phone = "01102602673",
                Rate = 4.9,
                AddressClinic = " المنطقة السادسة، مدينة نصر، محافظة القاهرة"
            },
            new Place 
            { 
                Name = "د. كمال شاروبيم امين",
                Longitude = 31.2527101,
                Latitude = 30.0491517,
                Phone = "01223902252",
                Rate = 4.3,
                AddressClinic = "49 عبد العزيز، العتبة، عابدين، محافظة القاهرة"
            },
            new Place 
            { 
                Name = "Kadah Clinic",
                Longitude = 31.916429,
                Latitude = 30.0797788,
                Phone = "01126024646",
                Rate = 4.9,
                AddressClinic = "بجوار الرقابـة الاداريـة - أعلى باشيونيـل، 10 النزهة، الجولف، مدينة نصر"
            },
            new Place 
            { 
                Name = "INDERM Skin Clinic",
                Longitude = 31.4370625,
                Latitude = 30.0188539,
                Phone = "01019777719",
                Rate = 4.6,
                AddressClinic = "Premier, Medical park, قسم ثالث القاهره الجديده، محافظة القاهرة"
            },
            new Place 
            { 
                Name = "Hers Clinic",
                Longitude = 31.3028027,
                Latitude = 30.0141436,
                Phone = "01155550447",
                Rate = 5.0,
                AddressClinic = "499 Street 9, شارع المقطم، محافظة القاهرة"
            },
            new Place 
            { 
                Name = "Dr.Maikandil",
                Longitude = 31.3336858,
                Latitude = 29.9745149,
                Phone = "01008185200",
                Rate = 5.0,
                AddressClinic = "البساتين الشرقية، قسم البساتين، محافظة القاهرة"
            },
            new Place 
            { 
                Name = "Dr. Amr Mostafa Clinic",
                Longitude = 30.0383907,
                Latitude = 31.2109472,
                Phone = "01008750875",
                Rate = 3.7,
                AddressClinic = "98 التحرير، الدقي، قسم الدقي، محافظة الجيزة "
            },
            new Place 
            { 
                Name = "Mag skin clinic",
                Longitude = 31.3131303,
                Latitude = 29.9612293,
                Phone = "01289311010",
                Rate = 4.2,
                AddressClinic = "معادي السرايات الغربية، قسم طرة، محافظة القاهرة "
            },
            new Place
            {
                Name = "DrDinaDorgham Maadi Clinic",
                Longitude = 31.2920177,
                Latitude = 29.9702183,
                Phone = "01005517868",
                Rate = 4.7,
                AddressClinic = "7 شارع 265، عزبة فهمي، قسم المعادي، محافظة القاهرة"
            },
            new Place
            {
                Name = "Derma Art Clinic",
                Longitude = 31.3116278,
                Latitude = 30.0103989,
                Phone = "01551618437",
                Rate = 5.0,
                AddressClinic = " Andrea Mokatam, الأباجية، المقطم، محافظة القاهرة "
            },
            new Place
            {
                Name = "My Derma Skin Clinic",
                Longitude = 31.4521138,
                Latitude = 30.0192858,
                Phone = "01228123577",
                Rate = 3.7,
                AddressClinic = "ميديكال بارك بريمير, ش التسعين الشمالي، محافظة القاهرة"
            },
            new Place
            {
                Name = "Dama Clinic",
                Longitude = 31.3638086,
                Latitude = 30.0597079,
                Phone = "01022108412",
                Rate = 4.4,
                AddressClinic = "بجوار صيدلية افريقيا اعلى كافيه, 43 second cup, مكرم عبيد"
            },
            new Place
            {
                Name = "Cutis The Skin Clinic",
                Longitude = 31.2202801,
                Latitude = 30.0521788,
                Phone = "0100907000",
                Rate = 3.9,
                AddressClinic = "الكوربة برج الأطباء ٢ ش الفيوم من ش كليوباترا, هليوبوليس, محافظة القاهرة"
            },
            new Place
            {
                Name = "Arab Organization for Industrialization Hospital",
                Longitude = 31.286,
                Latitude = 29.9840499,
                Phone = "01227020200",
                Rate = 3.2,
                AddressClinic = "ش العروبة، البساتين الشرقية، قسم المعادي، محافظة القاهرة"
            },
            new Place
            {
                Name = "Derma Life Clinic",
                Longitude = 31.2969775,
                Latitude = 29.9762222,
                Phone = "01122442259",
                Rate = 4.7,
                AddressClinic = "٦٥ شارع ٢٦٣ من شارع, طريق النصر، قسم المعادي، محافظة القاهرة"
            },
            new Place
            {
                Name = "Skin Pionneers",
                Longitude = 31.2950825,
                Latitude = 29.9771936,
                Phone = "01000911922",
                Rate = 4.1,
                AddressClinic = "زبة فهمي، قسم البساتين، محافظة القاهرة"
            },
            new Place
            {
                Name = "Skin Lounge Dermatology & Laser Center",
                Longitude = 31.2950825,
                Latitude = 29.9771936,
                Phone = "01024748463",
                Rate = 5.0,
                AddressClinic = "275 مكرر، عزبة فهمي، قسم البساتين، محافظة القاهرة"
            },
            new Place
            {
                Name = "Skin House Clinic",
                Longitude = 31.2939997,
                Latitude = 29.9770261,
                Phone = "01237691976",
                Rate = 4,
                AddressClinic = "47 Intersection Of rd، 79، معادي السرايات الغربية، قسم المعادي"
            },
            new Place
            {
                Name = "Algo Derma Beauty clinic",
                Longitude = 31.3008288,
                Latitude = 29.9612531,
                Phone = "01009427887",
                Rate = 4.3,
                AddressClinic = "معادي السرايات الغربية، قسم طرة، محافظة القاهرة"
            }
            new Place
{
    Name = "Hers Clinic",
    Longitude = 31.3028027,
    Latitude = 30.0141436,
    Phone = "01155550447",
    Rate = 5.0,
    AddressClinic = "499 Street 9, شارع المقطم، محافظة القاهرة"
},
            new Place
{
    Name = "Dr.Maikandil",
    Longitude = 31.3336858,
    Latitude = 29.9745149,
    Phone = "01008185200",
    Rate = 5.0,
    AddressClinic = "البساتين الشرقية، قسم البساتين، محافظة القاهرة"
},
            new Place
{
    Name = "Dr. Amr Mostafa Clinic",
    Longitude = 30.0383907,
    Latitude = 31.2109472,
    Phone = "01008750875",
    Rate = 3.7,
    AddressClinic = "98 التحرير، الدقي، قسم الدقي، محافظة الجيزة"
},
            new Place
{
    Name = "My Derma Skin Clinic",
    Longitude = 31.4521138,
    Latitude = 30.0192858,
    Phone = "01228123577",
    Rate = 3.7,
    AddressClinic = "ميديكال بارك بريمير, ش التسعين الشمالي، محافظة القاهرة"
},
            new Place
{
    Name = "Arab Organization for Industrialization Hospital",
    Longitude = 31.286,
    Latitude = 29.9840499,
    Phone = "01227020200",
    Rate = 3.2,
    AddressClinic = "ش العروبة، البساتين الشرقية، قسم المعادي، محافظة القاهرة"
},
            new Place
{
    Name = "Derma Life Clinic",
    Longitude = 31.2969775,
    Latitude = 29.9762222,
    Phone = "01122442259",
    Rate = 4.7,
    AddressClinic = "٦٥ شارع ٢٦٣ من شارع, طريق النصر، قسم المعادي، محافظة القاهرة"
},
            new Place
{
    Name = "Skin Pionneers",
    Longitude = 31.2950825,
    Latitude = 29.9771936,
    Phone = "01000911922",
    Rate = 4.1,
    AddressClinic = "زبة فهمي، قسم البساتين، محافظة القاهرة"
},
            new Place
{
    Name = "Skin Lounge Dermatology & Laser Center",
    Longitude = 31.2950825,
    Latitude = 29.9771936,
    Phone = "01024748463",
    Rate = 5.0,
    AddressClinic = "275 مكرر، عزبة فهمي، قسم البساتين، محافظة القاهرة"
},
            new Place
{
    Name = "Skin House Clinic",
    Longitude = 31.2939997,
    Latitude = 29.9770261,
    Phone = "01237691976",
    Rate = 4.0,
    AddressClinic = "47 Intersection Of rd، 79، معادي السرايات الغربية، قسم المعادي"
}

        };

        [HttpGet("ClinicsAPI")]
        public IActionResult GetClosestAndFarthest([FromQuery] double longitude, [FromQuery] double latitude)
        {
            var inputLocation = (longitude, latitude);

            foreach (var place in places)
            {
                var placeLocation = (place.Longitude, place.Latitude);
                double distance = CalculateDistance(inputLocation, placeLocation);
                place.Distance = distance;
            }

            return Ok(new
            {
                Clinics = places 
            });
        }

        private double CalculateDistance((double, double) location1, (double, double) location2)
        {
            double R = 6371; 
            var (lat1, lon1) = location1;
            var (lat2, lon2) = location2;
            var dLat = (lat2 - lat1) * (Math.PI / 180);
            var dLon = (lon2 - lon1) * (Math.PI / 180);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(lat1 * (Math.PI / 180)) * Math.Cos(lat2 * (Math.PI / 180)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var distance = R * c;
            return Math.Round(distance, 2);
        }
    }
}

