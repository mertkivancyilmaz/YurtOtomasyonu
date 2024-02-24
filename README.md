# 1. GİRİŞ 

 
Bu projeyi yapmak için Visual Studio kullandım.  Öncelikle Visual Studio'nun ne olduğunu ve sağladığı kolaylıkları yazacağım. Visual Studio, yazılımla ilgilenen kişilerin proje 
geliştirmelerinin yanı sıra proje yazmalarına ve çalıştırmalarına olanak sağlar. Ve bu uygulamanın tercih edilmesinin bazı sebepleri ise güzel bir arayüze sahip olmasıdır.
Ücretsiz sürümünde ise kodlama yapmak isteyen herkes proje yazabilir. Ben bu projemde C# kullandım.

İkinci olarak, kullandığımı bir veritabanı uygulamam var. Bu uygulamanın adı Microsoft SQL database. Bu uygulamanın ne olduğunu ve sağladığı kolaylıkları yazacağım. Microsoft SQL 
veritabanının amacı ilişkisel bir veritabanı uygulamasıdır. Böylece veritabanı yönetim sistemi olarak adlandırılabilir. Ve otomasyon projeleri için uygun bir veritabanıdır. Çünkü
diğer veritabanlarına göre daha karmaşık değildir ve projem bir form uygulaması olduğundan benim için yeterli olacaktır. Projemde Microsoft SQL veritabanını kullandım çünkü daha anlaşılır olduğu
için tercih ettim ve Microsoft SQL veritabanının amacı alınan bilgilerle çalışan formlar oluşturmak ve bilgileri o veritabanında saklamaktır. 

Yurt otomasyonu projemde ilk olarak Microsoft SQL veritabanında tablolar oluşturarak projemin ilk adımını attım. Veri tabanındaki toplam tablo sayısını 7 ana başlık altında düzenledim. 
Bu tabloları, yurt otomasyon projem için gerekli olan tüm "öğrenci, veli, personel ve istatistik" bilgilerini içerecek şekilde düzenledim. Microsoft SQL veritabanında oluşturduğum 7 ana 
tabloyu şu isimlerle oluşturdum: 

+ *Öğrenciler*  
+ *Bölümler*  
+ *Ödemeler*  
+ *Giderler*  
+ *İstatistik*  
+ *Yönetici*
+ *Erişim Kolaylığı*
> Erişim kolaylığının altında 4 ayrı başlık daha vardır. Bunlar :  
> + *Hesap Makinesi*  
> + *Paint*  
> + *Radyolar*  
> + *Hakkımızda*  
> + *Çıkış*  
 
Veritabanında oluşturduğum öğrenci bilgileri tablosuna ilk olarak şu bilgileri
ekledim: Öğrenciye ait id, ad, soyad, TC, telefon, doğum yılı, bölüm, mail, oda numarası, veli adı, veli telefonu ve veli adresi gibi tüm bilgiler bu tabloya kaydedilecektir. Veri tabanında
oluşturduğum ikinci tabloda üniversite bölümleri yer alıyor. Bu tablodaki bilgiler üniversite bölüm kimliği ve üniversite bölüm adı olmak üzere iki bilgi içeriyor.
Bu tablodaki bilgiler üniversite bölüm kimliği ve üniversite bölüm adı olmak üzere iki bilgi içeriyor. Veritabanında oluşturduğum üçüncü tablo odalar tablosuydu. Odalar tablosu şu bilgileri
içeriyor: Oda Id, Oda No, Oda Kapasitesi, Oda Aktif, Oda Durumu olarak odalar tablosunu oluşturdum. Veritabanında oluşturduğum dördüncü tabloyu admin tablosu olarak isimlendirdim.
Admin tablosu şu bilgileri içeriyor: Admin id, Admin name, Admin password bilgileri ile eklemeler yaptım. Veritabanında oluşturduğum beşinci tabloya Borçlar adını verdim. Borçlar tablosuna 
şu bilgileri ekledim: Öğrenci kimliği, Öğrenci adı, Öğrenci soyadı, Öğrencinin kalan borcu gibi bilgileri ekledim. Veritabanında altıncı tabloyu personel tablosu adı ile oluşturdum. Personel 
tablosu şu bilgileri içeriyor: Personel Kimliği, Personel Adı ve Soyadı, personel departmanı gibi bilgileri ekledim. Veri tabanında oluşturduğum son ve yedinci tabloyu giderler tablosu adı 
ile oluşturdum. Giderler tablosu şu bilgileri içeriyor: ödeme id, elektrik, su, doğalgaz, internet, yemek, personel gibi bilgileri içerecek şekilde ekledim. 
Öğrencilerin üniversitede okudukları bölümler bölüm tablosuna eklendi. Veritabanındaki odalar tablosuna oda numaraları bilgilerini ekledim. Bu şekilde yurt otomasyon projem için gerekli olan tüm
veritabanı tablolarını oluşturdum ve gerekli tüm bilgileri ekledim.
***
# 2.AMAÇ

Yapmış olduğum yurt otomasyon projesi ile yurt işletmeleri, yurtlara kayıtlı öğrencilerin bilgilerini tek bir platformda kayıt altına alabilir ve bu bilgileri düzenleyebilirim. Gelir-gider 
istatistiklerine ulaşabilirim. Bir yurt işletmesinin ihtiyacı olan tüm bilgilerin kayıt altına alınmasını sağlarım.

## 2.1.Proje Nasıl Kullanılır?

Proje bir otomasyon uygulamasıdır. Bu yüzden daha rahat ve konforludur. Veritabanı bağlantısı ile kullanılır. Öncelikle yurt otomasyonunu kullanmak için kayıtlı bir kullanıcı adı ve şifreye 
sahip olmak gerekir. Ancak bu şekilde otomasyona girebilir. Bu projem toplamda 7 sekmeden oluşmaktadır. Öğrenciler ile yeni öğrenci kaydı yapılabilir, kayıt güncellenebilir veya kayıt silinebilir. 
Bölümlerde ise yeni bölümler eklenebilir veya silinebilir. Ödemeler bölümünde ödeme alınır. Ödeme alındığında borç bakiyesi azalır. Gider istatistikleri İstatistikler sekmesinde gösterilir. 
Yeni yönetici ekleme ve çıkarma durumunda Yönetici sekmesinden işlem yapılabilir. Erişim Kolaylığı'nda bilgisayara bağlı sistemlerden radyo çalınabilir, Paint açılabilir, Hesap Makinesi açılabilir
veya program kapatılabilir. Tarih ve saat ana ekranda canlı olarak görüntülenir.

## 2.2.Projeyi neden kullanmalıyım?

Yapmış olduğum yurt otomasyon projesi öğrenci yurtlarında bilgi kontrolü ve yönteminin kullanılmasını sağlıyor. Bu sayede yurt işletmeleri kolay bilgi yönetimi sağlarlar. Bu otomasyon sayesinde 
zamandan ve iş gücünden tasarruf edilebilir. Bu sayede işçilik maliyeti azalacağı için kalan bütçe ile daha düşük maliyetlere bu program satın alınabilir.
***
# 3.HEDEF

Bu yurt otomasyonu projesinin temel amacı devlete bağlı veya bağımsız tüm yurt işletmelerine satmaktır. Bu işletmelere iş gücü tasarrufu vaadi ile pazarlanması hedeflenmektedir. Bu sayede programın
üretici firmaya kazandırılması hedeflenmektedir. Programa sürekli yatırımlar ile yazılım açıkları, güvenlik iyileştirmeleri, arayüz tasarımı ve sistem iyileştirmeleri için destek devam edecek. Yeni
güncellemeler ile güçlendirilecektir.
***
# 4.MATERYALLER VE YÖNTEMLER
Bu yurt otomasyonu projesini geliştirirken bize en büyük katkıyı araştırmalarımız sağladı. Materyal olarak en çok bilgiye internet üzerinden ulaştım. Gerekli ön bilgiye sahip olduktan sonra projemizin
yapım aşamalarını ve sürecini tasarladım. Veritabanı olarak Microsoft SQL veritabanını kullandım ve formları oluşturmak için C# yazılım dilini kullanarak Visual Studio 2019 üzerinde geliştirdim. Bu yurt 
otomasyon projesinde en önemli noktalardan biri olan veri tabanı ile ilgili çalışmalar yaptım ve kayıt bilgilerini her an kontrol edebilme imkanı yarattım.
***
# 5.YAPILAN ÇALIŞMALAR

Bu projeye başlamadan önce atacağımız adımları belirlediğimiz için projenin başlangıç ve bitiş zamanını diyagram ve grafik olarak belirttik. Bu yurt otomasyon projesini geliştirirken görev dağılımı yaptık.
Kullandığımız yazılım dili olan C# ve kullandığımız veri tabanı olan Microsoft SQL veri tabanı hakkında sürekli araştırma yaparak bu projeyi stabil ve hatasız bir proje haline getirdim.  

## 5.1 Diagram

[![Figure 1](https://r.resimlink.com/NisUtMzj.png)](https://resimlink.com/NisUtMzj)   
(Figure 1)  

Haftalar boyunca attığım adımları adım adım gösteren bir diyagramım var. İlk haftalarda, projenin başarılı bir şekilde ilerlemesi için veritabanı ve Visual Studio'nun sürüm uyumluluğunu kontrol ettim.
Programın düzgün çalışabilmesi için gerekli olan modülleri indirip kurulumunu tamamladım. Üçüncü haftadan itibaren projeye başlamak için gerekli olan programları indirdim ve kurulumunu gerçekleştirdim.
Beşinci haftadan sonra, veritabanı, arayüz ve otomasyonun gelişimine devam ettim. Sekizinci haftadan itibaren, veritabanı ve arayüzü birleştirerek proje temel bir taslak halinde tamamladım. Sonraki haftalarda
yapılan testlerle projenin işlevselliğini kontrol ettim ve gerekli hataları giderdim.

## 5.2.Graph
[![Figure 2](https://r.resimlink.com/6uxNg.png)](https://resimlink.com/6uxNg)  
(Figure 2)  
İşte projenin yapım sürecine dair zaman çizelgesinin grafiksel görünümü. Bu grafikte açıklamak istediğim şey şudur: Bu projenin inşasında önemli unsurlar araçlar ve ekipmanlar, araştırma ve zaman çerçevesi.
Bu nedenle, projemde kullandığım araçları ve malzemeleri kullanarak, araştırmaları yapma ve projem için hazır hale getirme aşamalarını gerçekleştirdim.
