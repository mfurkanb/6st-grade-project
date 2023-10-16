using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    string[] Metinler ={
        "Hey, şirketimize hoş geldin. Nasılsın? Umarım iyisindir. Sana nasıl hitap etmemi istersin?",
        "Ne de güzel bir isim. Benim adım da Muhammet. BAYAZİT inşaat şirketinin müdürüyüm." +
            "İşimiz bir takım ölçümler yaparak işçilerimizin doğru malzemeyi kullabilmesini sağlamak. " +
            "Senin de bu alanda ilgili olduğunu duyduk. Bakalım beraber neler yapabiliriz." ,
        "İlk olarak inşaatta kullanılacak çember şeklindeki kalıpları işçilerimizin kullanabilmesi için kontrol ediyoruz.",
        "Yan tarafta görmüş olduğun not defterini kullanarak yaptığın ölçümleri not etmeni isteyeceğim.",
        "Eğer bir sorun ile karşılaşırsan sana yardım etmek için her zaman hazır olacağım. " +
            "Yan taraftaki soru işaretini kullanarak benden yardım alabilirsin.",
        "Şimdi sana birkaç görev vereceğim. Bu görevleri sağ taraftaki butona basarak görebilirsin.",
        "Sonraki butonun basarak ilk görevine başlayabilirsin. Bol şans!",
        "Yan taraftaki siyah çember şeklindeki kalıbı işçilerimizin kullanması gerek. Bizim onlara bunları gönderebilmemiz için bazı hesaplamalar yapmamız gerek.",
        "Cetvelin başlangıç noktasını şekildeki gibi merkeze sabitleyerek çemberin herhangi bir yerine olan uzaklığını ölçmelisin.",
        "Daha sonra yine cetvel ile çemberin merkezinden geçen ve çemberin 2 farklı noktasını birleştiren uzunluğu ölçeceğiz. Bu da bize çapı verecek.",
        "Unutma, çap yarı çapın tam iki katı olmalı.",
        "Kolay gelsin :) Yardıma ihtiyacın olursa yardım butonunu kullanabilirsin.",
        "",
        "",
        "",
        "Haydi 2. görevine geçelim. İşçilerimizin ne kadar malzeme kullanacağını belirleyebilmeleri için çemberimizin çevresini bulmamız gerekiyor.", // 15
        "Elimizde bunun için bir makina var ve o makina çember şeklini düz bir çizgi haline getirebiliyor.",
        "Bu makinayı kullanarak az önce çapını 10 cm bulduğun çemberlerimizin çevre uzunluğunu ölçer misin?",
        "",
        "",
        "Çapı 10 cm olan çemberin çevresi 30 cm olarak rapora kaydedildi. Şimdi de çapı 12 cm olan çemberin çevresini hesapla.", // 20
        "",
        "Çapı 12 cm olan çemberin çevresini de 36 cm olarak buldun. Bunu da rapora ekledik. ",
        "Elimizde bir de beyaz renkli kalıplar var ancak makinemiz bunu düz hale getiremiyor.",
        "Mühendislerimiz bu çemberlerin çevresini bulabilmek için 2 x π x r formülünü kullanıyor.",
        "Bir mühendisimiz az önce şekildeki yarıçapı 4 ve çapı 8 cm olan çemberin çevresini 24 cm olarak buldu. ", // 25
        "Şimdi not defterine bir göz at ve diğer çemberlerin çevre uzunluğunu bulmaya çalışalım",
        "Fark ettin mi? Çemberin uzunluğunun çapa oranı π sayısını verdi. ",
        "Şekildeki çemberin yarı çapı 7 ama düz çizgi halline getiremiyoruz. Kimseye söyleme ama bu çemberin çevresinin uzunluğunu 42 cm olarak buldum " +
            "diğer çemberlerin uzunluğunu bulabilmemiz için π  sayısının kaç olduğunu bulman gerek.",
        "",
        "Bravo çok iyi gidiyorsun. Çember kalıplar konteynera yüklenecek birazdan. Son bir kaç tane hesaplama kaldı onları da yapar mısın? ", //30
        "",
        "",
        "",


    };












    public TextMeshProUGUI Ust_Bar;
    public GameObject Next_Button;
    public GameObject Back_Button;
    static public int page = -1;
    public GameObject Input_Panel;
    public TMP_InputField Input;
    public Animator Note_Book;
    public Animator Question_Mark;
    public Animator Task;
    public Animator char_anim;
    public GameObject canvas1;
    public GameObject canvas2;
    public Animator circle_anim;
    public Animator ruler_anim;
    public GameObject question_panel;
    public GameObject task_panel;
    public GameObject note_panel;
    public GameObject[] cm;
    public GameObject rapor1;
    public GameObject[] sorular1;
    public static int sorular_1 = 0;

    public TMP_Dropdown soru1;
    public TMP_Dropdown soru2;
    public TMP_Dropdown soru3;

    public Animator makine_anim;
    public Animator line;
    public Animator w_circle;

    public GameObject w_report;
    public GameObject wrond_w_report;
    public TMP_InputField w_report_q;

    public GameObject ilk_son_soru;
    public TMP_InputField ilk_son1;
    public TMP_InputField ilk_son2;
    public GameObject wrong_il_son;

    public Toggle ilk_gorev;
    public GameObject[] note_text;
    public GameObject notum;
    public Toggle[] toggle;

    int x = 0;

    public GameObject n_;
    public GameObject b_;

    public AudioSource ses;

    void Start()
    {
        Input = Input.GetComponent<TMP_InputField>();
        Ust_Bar = Ust_Bar.GetComponent<TextMeshProUGUI>();
        Ust_Bar.text = "";

        Question_Mark = Question_Mark.GetComponent<Animator>();
        Note_Book = Note_Book.GetComponent<Animator>();
        Task = Task.GetComponent<Animator>();

        char_anim = char_anim.GetComponent<Animator>();

        circle_anim = circle_anim.GetComponent<Animator>();
        ruler_anim = ruler_anim.GetComponent<Animator>();

        makine_anim = makine_anim.GetComponent<Animator>();
        line = line.GetComponent<Animator>();
        w_circle = w_circle.GetComponent<Animator>();

        w_report_q = w_report_q.GetComponent<TMP_InputField>();

        ilk_son1 = ilk_son1.GetComponent<TMP_InputField>();
        ilk_son2 = ilk_son2.GetComponent<TMP_InputField>();


        ilk_gorev = ilk_gorev.GetComponent<Toggle>();

        ses = ses.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
        
        
     
        Metinler[1] = Input.text.ToString() + " Ne de güzel bir isim. Benim adım da Muhammet. BAYAZİT inşaat şirketinin müdürüyüm.";
        if (page == 3)
        {
            Note_Book.Play("note");
            char_anim.Play("char_note");
        }
        if (page == 4)
        {
            Question_Mark.Play("note");
            char_anim.Play("char_q");
        }
        if (page == 5)
        {
            Task.Play("note");
            char_anim.Play("char_task");
        }
        if(page == 0)
        {
            char_anim.Play("greeting_char");
        }
        if (page == 7)
        {
            canvas1.SetActive(false);
            canvas2.SetActive(true);
            char_anim.Play("first_activity");
            circle_anim.Play("circle_giris");
        }
        if (page == 8)
        {
            ruler_anim.Play("ruler_giris");
        }
        if (page == 10)
        {
            ruler_anim.Play("cap_giris");
        }
        if (page == 12)
        {
            char_anim.Play("cik");
            circle_anim.Play("circle_ilk_soru");
            ruler_anim.Play("ruler_ilk_olcum");
            cm[0].gameObject.SetActive(true);
        }
        if (page == 13)
        {
            ruler_anim.Play("ruler_ikinci_olcum");
            cm[0].gameObject.SetActive(false);
            cm[1].gameObject.SetActive(true);
        }
        if (page == 14)
        {
            
            rapor1.SetActive(true);
            note_text[0].SetActive(true);
            kapat();
            ruler_anim.Play("ruler_cik");
            cm[1].gameObject.SetActive(false);
            circle_anim.Play("circle_cik");
        }
        if (page == 15)
        {
            toggle[0].isOn = true;
            char_anim.Play("char_gir");
            circle_anim.Play("circle_gir2");
        }
        if (page == 16)
        {
            makine_anim.Play("makine_giris");
        }
        if (page == 18)
        {
            char_anim.Play("char_cik2");
            makine_anim.Play("makine_kes1");
            circle_anim.Play("circle_bitti");
            line.Play("line_giris");
        }
        if (page == 19)
        {
            
            ruler_anim.Play("ruler_ucuncu");
            cm[2].gameObject.SetActive(true);

        }
        if (page == 21)
        {
            circle_anim.Play("circle_gir3");
            line.Play("line_cik");
            ruler_anim.Play("ruler_cik2");
            cm[2].gameObject.SetActive(false);
            
            makine_anim.Play("makine_kes1");


        }
        if (page == 22)
        {
            makine_anim.Play("makine_kes3");
            circle_anim.Play("circle_bitti2");
            cm[3].gameObject.SetActive(true);
            line.Play("line_gir2");
            ruler_anim.Play("ruler_dorduncu");
        }
        if (page == 23)
        {
            char_anim.Play("char_gir2");
            circle_anim.Play("circle_cik");
            line.Play("line_cik");
            ruler_anim.Play("ruler_cik");
            w_circle.Play("white_gir");
            makine_anim.Play("makine_cik");
        }
        if (page == 25)
        {
           
        }
        if (page == 26)
        {
            notum.gameObject.SetActive(true);
            Note_Book.Play("note");
            char_anim.Play("char_note");
        }

        if (page == 27)
        {
            char_anim.Play("tepkiver");
            
        }
        
        
        if (page == 29)
        {
            note_text[1].SetActive(true);
            note_text[0].SetActive(false);
            kapat();
            w_report.gameObject.SetActive(true);
            w_circle.Play("white_cik");
            ilk_gorev.isOn = false;

        }
        if (page == 31)
        {
            kapat();
            this.gameObject.SetActive(true);
            ilk_son_soru.SetActive(true);
            Next_Button.SetActive(false);
            Back_Button.SetActive(false);
        }
        if (page == 32)
        {
            Next_Button.SetActive(false);
            Back_Button.SetActive(false);
            ilk_gorev.isOn = true;
        }
        if (page == 33)
        {
            Next_Button.SetActive(false);
            Back_Button.SetActive(false);
            ilk_gorev.isOn = true;
        }
    }
    
    public void Next()
    {
        ses.Play();
        StartCoroutine(TypeWrite_Next());
        
        
    }

    public void Back()
    {
        StartCoroutine(TypeWrite_Back());


    }
    IEnumerator TypeWrite_Next()
    {
        page += 1;
        Ust_Bar.text = "";
        Next_Button.SetActive(false);
        Back_Button.SetActive(false);
        
        foreach (char i in Metinler[page])
        {
            Ust_Bar.text += i;

            if (i.ToString() == ".")
            {
                yield return new WaitForSeconds(0.5f);

            }
           
            else
            {
                yield return new WaitForSeconds(0.02f);
            }
            
        }
        if (page == 0)
        {
            Back_Button.SetActive(false);
            Input_Panel.SetActive(true);
        }
        else
        {
            Back_Button.SetActive(true);
        }
        Next_Button.SetActive(true);
        Back_Button.SetActive(true);

      
        
        
    }
    IEnumerator TypeWrite_Back()
    {
        
        Ust_Bar.text = "";
        Back_Button.SetActive(false);
        Next_Button.SetActive(false);
        foreach (char i in Metinler[page - 1])
        {
            Ust_Bar.text += i;

            if (i.ToString() == ".")
            {
                yield return new WaitForSeconds(1);

            }
            else
            {
                yield return new WaitForSeconds(0.05f);
            }
        }
        if (page == 0)
        {
            Back_Button.SetActive(false);
        }
        else
        {
            Back_Button.SetActive(true);
        }
        Back_Button.SetActive(true);
        Next_Button.SetActive(true);
        page -= 1;
    }
    public void close_button()
    {
        Input_Panel.SetActive(false);
        page =+ 1; 
        Ust_Bar.text = Metinler[page];
    }


    public void not_defteri_ac()
    {
        note_panel.SetActive(true);
        task_panel.SetActive(false);
        question_panel.SetActive(false);
        kapat();
    }
    public void task_defteri_ac()
    {
        note_panel.SetActive(false);
        task_panel.SetActive(true);
        question_panel.SetActive(false);
        kapat();
    }
    public void soru_defteri_ac()
    {
        note_panel.SetActive(false);
        task_panel.SetActive(false);
        question_panel.SetActive(true);
        kapat();
    }

    public void not_defter_kapat()
    {
        note_panel.SetActive(false);
        ac();
    }
    public void task_defter_kapat()
    {
        task_panel.SetActive(false);
        ac();
    }
    public void soru_defter_kapat()
    {
        question_panel.SetActive(false);
        ac();
    }
    public void ac()
    {
        Back_Button.SetActive(true);
        Next_Button.SetActive(true);
        this.gameObject.SetActive(true);
    }
     public void kapat()
    {

        Back_Button.SetActive(false);
        Next_Button.SetActive(false);
        this.gameObject.SetActive(false);
    }
    public void Q_Next()
    {
        sorular_1 += 1;
        
        if (sorular_1 == 1)
        {
            if (soru1.GetComponent<TMP_Dropdown>().value == 1)
            {
                sorular1[4].gameObject.SetActive(false);
                sorular1[sorular_1 - 1].gameObject.SetActive(false);
                sorular1[sorular_1].gameObject.SetActive(true);
                

            }
            else
            {
                sorular_1 -= 1;
                sorular1[4].gameObject.SetActive(true);

            }
        }
        if (sorular_1 == 2)
        {
            if (soru2.GetComponent<TMP_Dropdown>().value == 0)
            {
                sorular1[4].gameObject.SetActive(false);
                sorular1[sorular_1 - 1].gameObject.SetActive(false);
                sorular1[sorular_1].gameObject.SetActive(true);

            }
            else
            {
                sorular_1 -= 1;
                sorular1[4].gameObject.SetActive(true);

            }
        }
        if (sorular_1 == 3)
        {
            if (soru3.GetComponent<TMP_Dropdown>().value == 2)
            {
                sorular1[4].gameObject.SetActive(false);
                sorular1[sorular_1 - 1].gameObject.SetActive(false);
                sorular1[sorular_1].gameObject.SetActive(true);

            }
            else
            {
                sorular_1 -= 1;
                sorular1[4].gameObject.SetActive(true);

            }
        }



    }
    public void soruları_kapat()
    {
        sorular1[4].gameObject.SetActive(false);
    }

    public void soruları_bitir()
    {
        page += 1;
        sorular1[3].gameObject.SetActive(false);
        sorular1[4].gameObject.SetActive(false);
        ac();
        rapor1.SetActive(false);
        Ust_Bar.text = Metinler[15];
    }
    public void ilk_son_kaybettin()
    {
        wrong_il_son.SetActive(false);
    }

    public void w_report_kapat()
    {
        if (w_report_q.text == "3")
        {
            
            page += 1;
            w_report.SetActive(false);
            ac();
            Ust_Bar.text = Metinler[30];
        }
        else
        {
            wrond_w_report.SetActive(true);
        }
    }
    public void ilk_son_kapat()
    {
        if (ilk_son1.text == "18" && ilk_son2.text == "pi")
        {
            page += 1;
            ilk_son_soru.SetActive(false);
            this.gameObject.SetActive(true);
            
        }
        else
        {
            wrong_il_son.SetActive(true);
        }
    }
    public void sonraki_Act()
    {
        // 1. si 7de başlıyo.
        // 2. 15de
        // 3.sü 1 de.
        // 4 sü 18
        x += 1;

        if(x == 1)
        {
            page = 15;
            cm[1].gameObject.SetActive(false);
            ruler_anim.Play("ruler_cik");

        }
        if (x == 2)
        {
            char_anim.Play("char_cik2");
            page = 31;
            Back_Button.SetActive(false);
            Next_Button.SetActive(false);
            note_text[1].SetActive(false);
            note_text[0].SetActive(false);
            w_report.gameObject.SetActive(false);
            w_circle.Play("white_cik");
            ilk_gorev.isOn = true;
            n_.gameObject.SetActive(true);
            b_.gameObject.SetActive(true);
            char_anim.Play("char_gir2");
            circle_anim.Play("circle_cik");
            line.Play("line_cik");
            ruler_anim.Play("ruler_cik");
            makine_anim.Play("makine_cik");
            
        }
        if (x == 3)
        {
            GameManager2.page = 18;
            Ust_Bar.text = "1. Çimentonun hacmi 1 metreküptür. Mühendislerimiz için bu hacmi sürükleyerek makinenin ortasına götürür müsün?";

        }
        if (x == 4)
        {
            GameManager2.page = 24;
            note_text[4].SetActive(false);

        }

    }



}
