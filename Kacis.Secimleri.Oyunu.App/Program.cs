using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If.Else.Free.Time


{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("KAÇIŞ OYUNU:\n");
            Console.WriteLine("Önünüzü Görmediğiniz bir mağarada, sadece sağ/sol komutları ve belli belirsiz ip uçları ile kurtulmaya çalışacaksınız\n");
            Console.WriteLine("Verilen ip uçlarına dikkat ederek kurtulmayı deneyin\n UYARI: CEVAP OLARAK SADECE 'SAĞ/sağ' VEYA 'SOL/sol' YAZMALISINIZ AKSİ TAKTİRDE OYUN KAPANIR!\n");
            Console.WriteLine("Başlamak İçin 'ENTER'");
            Console.ReadKey();

            Console.WriteLine("\n \n BÖLÜM 1 -\nNormal bir gecede kendi yatağında uyuyordun, soğuk bir beton kokusu ve su damlama sesleri ile uyandın,");
            Console.WriteLine("Kendini bir anda bambaşka bir yerde, garip bir mağarada buldun");
            Console.WriteLine("Cebinde zippo taşıdığın için şanslısın, burası zifiri karanlık. zipponun ışığında iki yol görüyorsun, ve ilerlemelisin \n\nSağ taraf normal bir mağara yolu gibi,");
            Console.WriteLine("Sol taraf ise dar ve ölü gibi kokuyor\n Sağ mı? Sol mu ? ");
            string birinci = Console.ReadLine().ToLower();
            if (birinci == "sağ")//TODO: İLK YOLDAN NORMAL SEÇİLDİ
            {
                Console.WriteLine("\n \n BÖLÜM 2 -\nSağa döndün yürümeye başladın, biraz ilerledikten sonra yeniden yol ayrılıyor.");
                Console.WriteLine("\nSağ taraftan su sesi geliyor, \nSol taraftan kulak zarına basınç yapacak kadar şiddetli bir rüzgar \n Sağ mı? Sol mu ?");
                string sagikinci = Console.ReadLine().ToLower();
                if (sagikinci == "sağ")//TODO: SU SESİ SEÇİLDİ
                {
                    Console.WriteLine("\n \n BÖLÜM 3 -\nSu sesinin geldiği yöne doğru yürüdün ve patika yol yanında bir nehir devam ediyor,");
                    Console.WriteLine("Su hayattır derler, umarım bir yerden dışarıya akıyordur. \nBurada mahsur kalmak hoş değil değişik sesler de yankılanmaya başladı bir an önce çıkmalısın");
                    Console.WriteLine("İleride yol yeniden ikiye ayrılıyor, \n\nSağdaki yoldan su aşağı doğru akıyor, \nSoldaki yol ise yukarı doğru devam ediyor\n Sağ mı? Sol mu ?");
                    string sagucuncu = Console.ReadLine().ToLower();
                    if (sagucuncu == "sağ")//TODO: SU AKIYO SEÇİLDİ
                    {
                        Console.WriteLine("\n \n BÖLÜM 4 -\nSu hayattır mottosuna fazla takılmışsın sanırım, Su ile aşağı doğru devam ettin.");
                        Console.WriteLine("Ve sonunda ufak bir gölet çıktı karşına, etrafında sarkıtlar ve su damlatan ışık saçan dikitler var,");
                        Console.WriteLine("Gölet sağ tarafa doğru uzuyor ve tam önünde bir kütük su üzerinde sakince yüzüyor,");
                        Console.WriteLine("Sol tarafında ise insan yapımı şekillerle dolu bir duvar uzanıyor,");
                        Console.WriteLine("\nSağdaki yoldan devam edip kütüğü kayık gibi kullanmak mı?");
                        Console.WriteLine("Soldaki yolda duvarı takip etmek mi? \n Sağ mı? Sol mu ?");
                        string sagdorduncu = Console.ReadLine().ToLower();
                        if (sagdorduncu == "sağ")//TODO: KAYIK VE KURTULUŞA GİDEN YOL İLK ASAMA SEÇİLDİ
                        {
                            Console.WriteLine("\n \n BÖLÜM 5 -\nKütüğü kayık gibi kullanarak bir süre ilerledin, yolun sonu kayalarla kapalı bir tünele çıktı");
                            Console.WriteLine("Su sağdaki kayaların altından bir yere akıyor ve aktığı yerde ışık kırılmaları var,\nSuya girmek riskli, ama ya dışarı akıyorsa?");
                            Console.WriteLine("Sol taraftaki sıkışık kayalar da hareket ettirilebilir gibi görünüyor, riskli bir seçim,");
                            Console.WriteLine("\nSağdan suya dalarak suyun aktığı yerdeki ışık kaynağını bulmak mı?\nSoldaki kayaları kaldırmaya çalışmak mı?\n Sağ mı? Sol mu?");
                            string sagbesinci = Console.ReadLine().ToLower();
                            if (sagbesinci == "sağ") //TODO: YÜZEREK KURTULUŞ SEÇİLDİ
                            {
                                Console.WriteLine("\n \n .....KURTULDUN..... \nSuya daldın, akıntının yardımıyla ilerlerken suda ışık kırılmalarının arttığını farkettin,");
                                Console.WriteLine("Işığı takip ederken akıntıya karşı koyamaz hale geldin,");
                                Console.WriteLine("Hızla ışığa doğru sürükleniyordun ve bir anda kendini bir vadide sakin bir akarsuda buldun");
                                Console.WriteLine("Vadinin karşı yakasında bir köy ve insanlar var");
                                Console.WriteLine("\n hayatının geri kalanında da karanlıklar arkanda aydınlık önünde olsun \n oynadığın için teşekkürler çıkmak için 'enter'");
                                Console.ReadKey();
                            }
                            else if (sagbesinci == "sol") //TODO: ENKAZ ALTINDA KALMA SEÇİLDİ KURTULUŞ 1 HAMLE İLE KAÇTI
                            {
                                Console.WriteLine("\n \n .....ÖLDÜN..... \nKayaların içinde olduğun tünelin yapı taşları olduğunu es geçerek, bir kilit taşını oynattın.");
                                Console.WriteLine("Enkaz altında ezildin...");
                                Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                                Console.ReadKey();
                            }
                            else
                            {
                                return;
                            }

                        }
                        else if (sagdorduncu == "sol")//TODO: DUVARI TAKİP ET SEÇİLDİ
                        {
                            Console.WriteLine("\n \n BÖLÜM 5 -\nİnsan yapımı gibi şekillerle dolu duvarı takip ettin,");
                            Console.WriteLine("Anlaması imkansız, çok eski bir dilde yazılar var, ve sağda bir kapı gördün, ama kulpu yok,");
                            Console.WriteLine("İtekleyerek açılabilir gibi görünüyor,");
                            Console.WriteLine("Sol tarafta ise derinliğini anlayamadığın bir çukur var, ya dibinde su varsa ve çıkış yolu buradaysa?");
                            Console.WriteLine("\nSağ taraftaki garip kapı mı? \nSol taraftaki çukura atlamak mı? \n Sağ mı? Sol mu?");
                            string sagdordunsolu = Console.ReadLine().ToLower();
                            if (sagdordunsolu == "sağ")//TODO: GARİP KAPI SEÇİLDİ 1 KURTULUŞ BURADA
                            {
                                Console.WriteLine("\n \n BÖLÜM 6 - \nKapıyı zorladın ve sürüklenerek açıldı, içerisi ışık saçan maddelerle dolu,");
                                Console.WriteLine("Anlaşılan bir hazine odası buldun, sağ tarafa doğru uzanan parıltılı altın bir yol var");
                                Console.WriteLine("Ve ucunda bir altın vazo, taştan bir kürsüde duruyor. Hemen ilerisinde çimenler görüyorsun, burası çıkış olabilir!");
                                Console.WriteLine("Solda ise ilk açtığınla aynı ebatlarda bir kapı, ve alt kısmından rüzgar geliyor ve rüzgarda toprak kokusu var");
                                Console.WriteLine("\nSağdan hazineyi alıp çimenliğe ilerlemeyi mi seçiyorsun");
                                Console.WriteLine("Soldaki kapıdan rüzgarın ve toprak kokusunun peşinden mi gidiyorsun?\n Sağ mı? Sol mu?");
                                string hazinehayat = Console.ReadLine().ToLower();
                                if (hazinehayat == "sağ")//TODO: TUZAKLANMIŞ ÖLÜM SEÇİLDİ
                                {
                                    Console.WriteLine("\n \n .....ÖLDÜN..... \nAnlaşılan çok eski bi uygarlığın, eski bir hazinesini buldun,");
                                    Console.WriteLine("Bu hazineyi neredeyse kimsenin bulamayacağı bir yere saklamaya çalışmışlar");
                                    Console.WriteLine("Ve bulunma ihtimaline karşı, tuzaklamışlar, mağara üzerine yıkıldı...");
                                    Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                                    Console.ReadKey();
                                }
                                else if (hazinehayat == "sol")//TODO: PARAYI BOŞVER VE KURTUL SEÇİLDİ
                                {
                                    Console.WriteLine("\n \n .....KURTULDUN..... \nKapı açıldı, ve toprak yolun ucunda gün ışığını gördün.");
                                    Console.WriteLine("Koşarak dışarı çıktın. Görünen o ki 'Bir vadidesin' ve karşıda bir köy ve insanlar var.");
                                    Console.WriteLine("\n hayatının geri kalanında da karanlıklar arkanda aydınlık önünde olsun \n oynadığın için teşekkürler çıkmak için iki kez 'enter' bas");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else if (sagdordunsolu == "sol")//TODO: ÇUKURA ATLANIP ÖLÜM SEÇİLDİ
                            {
                                Console.WriteLine("\n \n .....ÖLDÜN..... \nÇukura atladın, metrelerce yükseklikten sert kayalara çakıldın, hayat ihtimallerle yaşanmaz...");
                                Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                                Console.ReadKey();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    else if (sagucuncu == "sol")//TODO: SUYU BIRAK YUKARI GİT SEÇİLDİ
                    {
                        Console.WriteLine("\n \n BÖLÜM 4 -\nSuyu bırakıp yukarı gittin. Yokuş gittikçe dikleşti,");
                        Console.WriteLine("Tırmanmaya devam ediyordun ki artık tırmanmanın çok zor hale geldiği noktada");
                        Console.WriteLine("Sol tarafta pencere benzeri bir açıklık gördün ve aşağı baktın,");
                        Console.WriteLine("10-15 metre yukseklik ve aşağıda su var sudan ışık yansıyor bu demek oluyor ki dışarı açılıyor");
                        Console.WriteLine("Sağ tarafta dik yokuş var ve yukarısı aydınlık,");
                        Console.WriteLine("\nSağdan yokuşu takip etmek ve ışığa tırmanmak mı?");
                        Console.WriteLine("Soldan suya atlamak ve sudaki ışığa gitmek mi? \n Sağ mı? Sol mu?");
                        string tırmandal = Console.ReadLine().ToLower();
                        if (tırmandal == "sağ")//TODO: TIRMAN KURTUL SEÇİLDİ
                        {
                            Console.WriteLine("\n \n .....KURTULDUN..... \nZor da olsa ışığı takip ederek tırmanmayı başardın ve açıklıktan dışarı çıktın.");
                            Console.WriteLine("Temiz hava ile rahatladın, bir vadinin yüksek bir bölümündesin, manzaranda sakin bir akarsu var");
                            Console.WriteLine("Akarsuyun hemen karşısında ise bir köy... tebrikler");
                            Console.WriteLine("\n hayatının geri kalanında da karanlıklar arkanda, aydınlık önünde olsun \n oynadığın için teşekkürler çıkmak için iki kez 'enter' bas");
                            Console.ReadKey();
                        }
                        else if (tırmandal == "sol")//TODO: SUYA ATLA DELİK DEŞİK OL SEÇİLDİ
                        {
                            Console.WriteLine("\n \n .....ÖLDÜN..... \nDerinliğini bilmediğin suya atladın, sivri dikitlerle dolu ve çok sığ olan suya çakıldın");
                            Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                            Console.ReadKey();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {
                        return;
                    }

                }
                else if (sagikinci == "sol")//TODO: RÜZGAR SESİ ÖLÜMLÜ YOL SEÇİLDİ
                {
                    Console.WriteLine("\n \n .....ÖLDÜN..... \nDoğanın 'bana yaklaşma' deme şekli bu şiddetli rüzgar oldu. Rüzgar zipponu söndürdü ");
                    Console.WriteLine("karanlıkta ne yapacağını şaşırdığın bir adna yürürken rüzgarın da savurmasıyla içerideki bir uçurumdan düşerek öldün");
                    Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                    Console.ReadKey();
                }
                else
                {
                    return;
                }

            }
            else if (birinci == "sol")//TODO: İLK YOLDAN ÖLÜMLÜ YOL SEÇİLDİ
            {
                Console.WriteLine("\n \n BÖLÜM 2 - \nSola döndün berbat koku ile dar bir geçitte ilerlemeye başladın,");
                Console.WriteLine("Ve önünde yeniden yollar ayrılıyor, \nSağ taraftaki yoldan yoğun koku geliyor,");
                Console.WriteLine("Sol taraftaki yolda ise tıslama sesleri var. \n Sağ mı? Sol mu?");
                string solikinci = Console.ReadLine().ToLower();
                if (solikinci == "sağ")//TODO: METAN GAZI PATLAMASI SEÇİLDİ
                {
                    Console.WriteLine("\n \n .....ÖLDÜN..... \nKapalı bir alanda, elinde ateşle metan gazı dolu yolu tercih ettin,");
                    Console.WriteLine("Ve tünel yüksek basınçla infilak etti...");
                    Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                    Console.ReadKey();
                }
                else if (solikinci == "sol")//TODO: YILAN SOKMASI SEÇİLDİ
                {
                    Console.WriteLine("\n \n .....ÖLDÜN..... \nKaranlıkta bilmediğin bir yerde tıslama sesini takip ettin,");
                    Console.WriteLine("Karılaştığın bir yılan tarafından sokuldun ve zehirlenerek öldün...");
                    Console.WriteLine("Çıkmak için 'ENTER' a iki kez bas, tekrar denemen için yine bekleriz");
                    Console.ReadKey();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            Console.ReadKey();
        }
    }
}

