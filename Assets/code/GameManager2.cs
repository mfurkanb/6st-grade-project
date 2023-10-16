using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{

    string[] Metinler = {
        "Uzunluklarını kontrol ettiğin kalıplar küp şeklindeki paketlere dolduruldu.",
        "Paketin hacmi 1 metre küp. Yani paketin her biri bir birimküptür\n",
        "Unutma, hacmi 1 birim olan küpe birimküp denir. \n",
        "Bu birimküpler şekildeki gibi konteynerın her yerini kaplayacak şekilde doldurulacak.",
        "Bu birimküpler dikdörtgenler prizma şeklindeki konteynırın tamamını dolduracak şekilde yerleştiriliyor.",
        "İlk konteynerın sorumlusu konteynerın hacminin 18 metrekare olduğunu söylüyor. \n", 
        "İlk konteynerın tamamı doluyor. Konteynerda yere konulmuş 6 tane birimküp ve her birimküpün üstünde 2 birimküp daha vardır.\n", //5
        "İkinci konteynerın sorumlusu konteynerın hacminin 8 metrekare olduğunu söylüyor. \n",
        "İkinci konteynerın da tamamı doluyor. Konteynerda yere konulmuş 4 tane birimküp ve her birimküpün üstünde 1 birimküp daha vardır.\n",
        "Üçüncü konteynerın sorumlusunu hasta olduğu için bugün işe gelemedi. Bu yüzden üçüncü konteynerın hacmini bilmiyoruz.\n",
        "Üçüncü konteynerın tamamı birimküplerle şekildeki gibi dolduruluyor. Tabanında 8 birimküp ve her bir birimküpün üstünde 1 tane daha birimküp vardır\n", 
        "Üçüncü konteynerın hacmini bulabilir misin?", //10
        "",
        "Tebrikler, az önce üçüncü konteynerın sorumlusu aradı ve hacmi doğru bulduğunu söyledi.",
        "Ayrıca  konteynerların hacmini tabandaki birimküp sayısı ile üst üste konulan toplam birimküp sayısının çarpımı ile bulabileceğimizi söyledi. " +
        "Kalan konteynerları bu yöntemle bulabilir misin?", // 13
        "Dördüncü konteynerın tabanında 10 tane birimküp var. Üst üste de 5 tane birimküp var." +
        "Beşinci konteynerın tabanında ise 7 tane birimküp var. Üst üste de 8 tane birimküp var.", //14
        "",
        "Tebrikler başarı ile tamamladın.Paketleri işçilerimize gönderebilmemiz bir sonraki aşamaya geçmemiz gerekiyor.",
        "Sıradaki görevine hazırsın. Elimizde birtakım çimentolar var ve bunların hacimlerini ustalarım ölçtü. " +
        "Ancak bu ölçüleri mühendislerimize bildirmek için bazı birim dönüşümleri yapmamız gerek. Birim dönüştürme işleminde işte bu makine sana yardımcı olacak",
        "1. Çimentonun hacmi 1 metreküptür. Mühendislerimiz için bu hacmi sürükleyerek makinenin ortasına götürür müsün?", //19
        "Tebrikler 2. çimentonun hacmi 500  desimetreküptür. \nMühendislerimiz için bu hacmi sanitmetreküpe çevirir misin?", 
        "Tebrikler, o da ne eyvah, makina bozuldu. Bundan sonraki çimentoların hacimlerin birimlerini senin çevirmen gerek. Yardıma ihtiyacın olursa beni çağırmayı unutma.", 
        "", // 21
        "Tebrikler hepsini doğru yaptın, son görevine başlayabilirsin.", //22
        "",
        "",
        "Son aşamada işçilere gidecek olan suyun şişelere, özel bir yağın da bidonlara doldurulması gerek. Bunun için gerekli ölçümlere yardımcı olmalısın\n",
        "Bu özel yağlar bize şırınga ile geliyor. Her bir şırınga 10 mililitre bunları 1’er santilitrelik şişelere dolduruluyor.\nSular ise 1’er santilitrelik şişelerde geliyor. " +
            "Bunlar da 1’er litrelik bidonlara dolduruluyor.\n",
        "Senin buradaki görevin eski raporlara bakıp yeni gelecek su ve yağların hesaplamalarını kontrol etmen gerekiyor." +
            "Eski raporları görmeni tavsiye ediyorum",
        "Sen rapora bakarken yeni gelecek ürünlere baktım ve şirketimiz yeni bir firmayla anlaştığı için ürünlerin farklı hacimlerdeki kaplarda geldiğini gördüm.\nYeni hesaplamalar için yardımına ihtiyacımız var.\n",
        "Yeni firma yağları 20 mL lik şırıngalarda getirdi. Bu yağları 5’er santilitrelik şişelere doldurmamız gerek." +
            "Sular ise 2’şer santilitrelik şişelerde getirildi ve 3 litrelik bidonlara doldurulacak.",
        "Eski raporu inceleyip yeni hesaplamaları yapar mısın, haydi devam et",
        "",
        "",
        "",
        "",





    };
    


    public static int page = 0;
    private GameManager kapat;
    public GameObject[] objects;
    public TextMeshProUGUI ust_bar;
    public Animator anim;
    public TMP_InputField ilk_soru;
    public TMP_InputField ikinci_soru;
    public TMP_InputField ucuncu_soru;
    public Toggle[] toggle;

    public TMP_InputField sise;
    public TMP_InputField bidon;

    public AudioSource ses;


    // Start is called before the first frame update
    void Start()
    {
        ust_bar = ust_bar.GetComponent<TextMeshProUGUI>();
        anim = anim.GetComponent<Animator>();
        ilk_soru = ilk_soru.GetComponent<TMP_InputField>();
        ucuncu_soru = ucuncu_soru.GetComponent<TMP_InputField>();

        sise = sise.GetComponent<TMP_InputField>();
        bidon = bidon.GetComponent<TMP_InputField>();

        ses = ses.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameManager.page == 31)
        {
            objects[0].SetActive(true);
            objects[1].SetActive(true);
            ust_bar.text = Metinler[0];
            
        }
        if (page == 1)
        {
            anim.Play("act2_gir");
            objects[2].SetActive(true);
        }
        if (page == 3)
        {
            objects[2].SetActive(false);
            objects[3].SetActive(true);
        }

        if (page == 5)
        {
            objects[3].SetActive(false);
        }
        if (page == 6)
        {

            objects[4].SetActive(true);
        }
        if (page == 8)
        {

            objects[4].SetActive(false);
            objects[5].SetActive(true);
        }
        if (page == 9)
        {
            //kapat.note_text[1].SetActive(false);
            objects[5].SetActive(false);
            objects[6].SetActive(true);
            //kapat.note_text[2].SetActive(true);
        }
        if (page == 11) // soruyu açtık
        {
          
            anim.Play("sola_geç");
            objects[7].SetActive(true);
        }
        if (page == 12)
        {
            if (ilk_soru.text == "16")
            {
                page += 1; // page == 12
                ust_bar.text = Metinler[page];
                objects[7].SetActive(false);
                objects[6].SetActive(false);
            }
            else
            {
                
                page -= 1;
                ust_bar.text = "Sanırım ufak bir hata oldu, haydi tekrar dene.";
            }
        }
        if(page == 15)
        {
            objects[8].SetActive(true);
        }
        if (page == 16)
        {
            
            if (ikinci_soru.text == "50" && ucuncu_soru.text == "56")
            {
                page += 1; // page = 15
                ust_bar.text = Metinler[page];
                kapat.toggle[1].isOn = true;
                
            }
            if(ikinci_soru.text != "50" && ucuncu_soru.text == "56")
            {
                
                ust_bar.text = "Dördüncü konteynerın haacmini hesaaplarkan bir hata oldu, haydi tekrar dene.";
                page -= 1;
            }
            if (ikinci_soru.text == "50" && ikinci_soru.text != "56")
            {
                
                ust_bar.text = "Beşinci konteynerın haacmini hesaaplarkan bir hata oldu, haydi tekrar dene.";
                page -= 1;
            }
        }
        if (page == 18)
        {
           
            objects[2].SetActive(false);
            objects[3].SetActive(false);
            objects[4].SetActive(false);
            objects[5].SetActive(false);
            objects[6].SetActive(false);
            objects[7].SetActive(false);
            objects[8].SetActive(false);
            objects[9].SetActive(true);
        }
        if (page == 19)
        {
           
            objects[0].SetActive(true);
            objects[1].SetActive(true);
        }
        if (page == 20)
        {
            
            objects[11].SetActive(false);
            objects[12].SetActive(false);
            objects[10].SetActive(true);
            objects[0].SetActive(true);
            objects[1].SetActive(true);
        }
        if (page == 21)
        {
            objects[9].SetActive(false);
            
        }
        if (page == 22)
        {
            objects[13].SetActive(true);
            kapat.note_text[2].SetActive(false);
            kapat.note_text[3].SetActive(true);

        }
        if (page == 23)
        {
            if (toggle[0].isOn && toggle[1].isOn)
            {
                page += 1; // page = 24
                ust_bar.text = "Tebrikler hepsini doğru yaptın, son görevine başlayabilirsin.";
            }
            if (!toggle[0].isOn)
            {
                ust_bar.text = "Metreküpten santimetreküpe çevirirken hata yaptın, haydi tekrar dene.";
                page -= 1;
            }
            if (toggle[1].isOn)
            {
                ust_bar.text = "Desimetreküpten metreküpe çevirirken hata yaptın, haydi tekrar dene.";
                page -= 1;
            }

        }
        if (page == 25)
        {
            objects[13].SetActive(false);
            anim.Play("act2_gir");
        }
        if (page == 27)
        {
            objects[14].SetActive(true);
            objects[15].SetActive(false);
        }
        if (page == 31)
        {
            objects[16].SetActive(true);
            objects[17].SetActive(true);
        }
        if (page == 32)
        {
            if (sise.text == "4" && bidon.text == "3")
            {
                objects[16].SetActive(false);
                objects[17].SetActive(false);
                ust_bar.text = "Çok tebrik ederim, ne kadar başarılı bir yardımcı olduğunu gösterdim";
                objects[0].SetActive(false);
                objects[1].SetActive(false);
                objects[18].SetActive(true);

            }
            else
            {
                page -= 1;
                ust_bar.text = "Ufak bir hata yaptın, haydi tekrar dene";
            }
            
        }


    }

    public void ileri()
    {
        ses.Play();
        StartCoroutine(TypeWrite_Next());
        
    }


    public void geri()
    {
        StartCoroutine(TypeWrite_Back());
    }





    IEnumerator TypeWrite_Next()
    {
        Debug.Log(page);
        page += 1;
        ust_bar.text = "";
        objects[0].SetActive(false);
        objects[1].SetActive(false);

        foreach (char i in Metinler[page])
        {
            ust_bar.text += i;

            if (i.ToString() == ".")
            {
                yield return new WaitForSeconds(0.5f);

            }

            else
            {
                yield return new WaitForSeconds(0.02f);
            }

        }
        
        objects[0].SetActive(true);
        objects[1].SetActive(true);




    }
    IEnumerator TypeWrite_Back()
    {
        ust_bar.text = "";
        objects[1].SetActive(false);
        objects[0].SetActive(false);
        foreach (char i in Metinler[page-1])
        {
            ust_bar.text += i;

            if (i.ToString() == ".")
            {
                yield return new WaitForSeconds(1);

            }
            else
            {
                yield return new WaitForSeconds(0.05f);
            }
        }
        
        objects[1].SetActive(true);
        objects[0].SetActive(true);
        page -= 1;
    }
    public void kapatt()
    {
        Application.Quit();
    }

   
}
