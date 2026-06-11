using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void americanSniper2014ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aksiyon1;
            textBox1.Text = "Donanma S.E.A.L. keskin nişancısı Chris Kyle'ın nokta atışı isabetliliği, savaş alanında sayısız hayat kurtarıyor ve onu bir efsaneye dönüştürüyor. Ancak dört görev turundan sonra ailesiyle birlikte eve dönen Chris, geride bırakamayacağı savaşın bu olduğunu fark eder.";
        }

        private void looper2012ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aksiyon2;
            textBox1.Text = "2074'te, mafya birinden kurtulmak istediğinde, hedef geçmişe gönderilir ve burada kiralık bir silah bekler - Joe gibi biri - bir gün mafyanın Joe'nun gelecekteki benliğini suikast için geri göndererek 'döngüyü kapatmak' istediğini öğrenir.";
        }

        private void edgeOfTomorrow2014ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aksiyon3;
            textBox1.Text = "Uzaylılarla savaşan bir asker aynı günü tekrar tekrar yaşar, her öldüğünde gün yeniden başlar.";
        }

        private void ıAmLegend2007ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.aksiyon4;
            textBox1.Text = "Bir vebanın insanlığın çoğunu öldürmesinden ve geri kalanını canavarlara dönüştürmesinden yıllar sonra, New York'ta hayatta kalan tek kişi bir tedavi bulmak için cesurca mücadele eder.";
        }

        private void hotaruNoHaka1988ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.animasyon1;
            textBox1.Text = "Genç bir çocuk ve küçük kız kardeşi, II. Dünya Savaşı sırasında Japonya'da hayatta kalma mücadelesi veriyor.";
        }

        private void mononokehime1997ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.animasyon2;
            textBox1.Text = "Bir Tatarigami'nin lanetine çare bulmak için çıktığı yolculukta Ashitaka, kendini orman tanrıları ile bir maden kolonisi olan Tatara arasındaki savaşın ortasında bulur. Bu arayışta Mononoke Hime San ile de tanışır.";
        }

        private void wALLE2008ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.animasyon3;
            textBox1.Text = "Uzak bir gelecekte, küçük bir atık toplama robotu, istemeden insanlığın kaderini belirleyecek bir uzay yolculuğuna çıkar.";
        }

        private void toyStory1995ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.animasyon4;
            textBox1.Text = "Bir kovboy bebeği, yeni bir uzay adamı aksiyon figürü, bir çocuğun yatak odasında en iyi oyuncak olarak onun yerini aldığında derinden tehdit edilir ve kıskançtır.";
        }

        private void contact1997ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.bilim1;
            textBox1.Text = "Dr. Ellie Arroway, yıllarca süren araştırmalardan sonra, dünya dışı zekanın kesin radyo kanıtını bulur ve gizemli bir makine için planlar gönderir.";
        }

        private void aSpaceOdyssey1968ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.biilim2;
            textBox1.Text = "Ay yüzeyinin altına gömülü gizemli bir eseri ortaya çıkardıktan sonra, kökenlerini bulmak için Jüpiter'e bir uzay aracı gönderilir: iki adam ve süper bilgisayar HAL 9000 tarafından yönetilen bir uzay aracı.";
        }

        private void aIArtificialIntelligence2001ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.bilim3;
            textBox1.Text = "Son derece gelişmiş bir robot çocuk, insan annesinin sevgisini yeniden kazanabilmek için \"gerçek\" olmayı özlüyor.";
        }

        private void exMachina2014ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.bilim4;
            textBox1.Text = "Genç bir programcı, son derece gelişmiş bir insansı yapay zekanın insani niteliklerini değerlendirerek sentetik zekada çığır açan bir deneye katılmak üzere seçilir.";
        }

        private void reptile2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dram1;
            textBox1.Text = "Tom Nichols, hiçbir şeyin göründüğü gibi olmadığı ve kendi hayatındaki yanılsamaları ortadan kaldırmaya başladığı bir davanın peşinden koşan, sert bir New England dedektifidir.";
        }

        private void theCreator2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dram2;
            textBox1.Text = "Yapay zekaya sahip insanlar ve robotlar arasındaki bir savaşın arka planında, eski bir asker gizli silahı, küçük bir çocuk şeklinde bir robotu bulur.";
        }

        private void nowhereII2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dram3;
            textBox1.Text = "Mia adında genç bir hamile kadın, bir kargo gemisinde bir deniz konteynırında saklanarak savaş halindeki bir ülkeden kaçar. Şiddetli bir fırtınadan sonra Mia, hayatta kalmak için savaşması gereken denizde kaybolan çocuğu doğurur.";
        }

        private void hauntedMansion2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.dram4;
            textBox1.Text = "Gabbie adında bekar bir anne, hayaletlerin yaşadığını keşfettikten sonra yeni satın aldığı malikanesini kovmaya yardımcı olması için bir tur rehberi, bir medyum, bir rahip ve bir tarihçi tutar.";
        }

        private void aQuietPlace2018ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gerilim1;
            textBox1.Text = "Bir aile, çoğu insanın kör ama gürültüye duyarlı yaratıklar tarafından öldürüldüğü bir dünyada hayatta kalma mücadelesi veriyor. Yaratıkları uzak tutmak için işaret dilinde iletişim kurmak zorunda kalıyorlar.";
        }

        private void dontBreathe2016ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gerilim2;
            textBox1.Text = "Büyük bir servetle çekip gitmeyi uman üç hırsız, göründüğü kadar çaresiz olmayan kör bir adamın evine girer.";
        }

        private void theShallows2016ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gerilim3;
            textBox1.Text = "Kıyıdan sadece 200 metre uzakta olan sörfçü Nancy, büyük beyaz bir köpekbalığının saldırısına uğrar ve güvenliğe yaptığı kısa yolculuk, nihai irade yarışmasına dönüşür.";
        }

        private void ıtI2017ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gerilim4;
            textBox1.Text = "1989 yazında, zorbalığa uğrayan bir grup çocuk, palyaço kılığına giren ve küçük Maine kasabası Derry'nin çocuklarını avlayan şekil değiştiren bir canavarı yok etmek için bir araya gelir.";
        }

        private void theSixthSense1999ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.korku1;
            textBox1.Text = "Bir çocuk psikoloğu olan Malcolm Crowe, ölü insanlarla karşılaşan ve onu onlara yardım etmeye ikna eden genç bir çocuk olan Cole'u tedavi etmeye başlar. Buna karşılık Cole, Malcolm'un ayrı yaşadığı karısıyla uzlaşmasına yardım eder.";
        }

        private void ıdentity2003ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.korku2;
            textBox1.Text = "Kötü bir yağmur fırtınası sırasında ıssız bir Nevada motelinde mahsur kalan on yabancı, birer birer öldürüldüklerini fark ettiklerinde birbirleriyle tanışırlar.";
        }

        private void carrie2013ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.korku3;
            textBox1.Text = "Akranları tarafından dışlanan ve dindar annesi tarafından korunan utangaç bir kız, mezuniyet balosunda çok ileri itildikten sonra küçük kasabasında telekinetik terör salıyor.";
        }

        private void ınsidiousI2010ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.korku4;
            textBox1.Text = "Bir aile, kötü ruhların komadaki çocuklarını The Further adlı bir alemde tuzağa düşürmesini önlemeye çalışır.";
        }

        private void hauntedMansion2023ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.komedi1;
            textBox1.Text = "Gabbie adında bekar bir anne, hayaletlerin yaşadığını keşfettikten sonra yeni satın aldığı malikanesini kovmaya yardımcı olması için bir tur rehberi, bir medyum, bir rahip ve bir tarihçi tutar.";
        }

        private void barbieI2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.komedi2;
            textBox1.Text = "Barbie, dünyasını ve varlığını sorgulamasına neden olan bir kriz yaşar.";
        }

        private void totallyKiller2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.komedi3;
            textBox1.Text = "Kötü şöhretli \"Sweet Sixteen Killer\", ilk cinayet çılgınlığından 35 yıl sonra başka bir kurban talep etmek için geri döndüğünde, 17 yaşındaki Jamie yanlışlıkla zamanda geriye 1987'ye gider ve katili başlamadan önce durdurmaya kararlıdır.";
        }

        private void elemental2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.komedi4;
            textBox1.Text = "Ateş, su, toprak ve hava sakinlerinin bir arada yaşadığı bir şehirde Ember ve Wade'i takip ediyor.";
        }

        private void limitlessI2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mcr1;
            textBox1.Text = "Kullanıcının beyninin yeteneklerinin %100'üne erişmesini sağlayan gizemli bir hap, mücadele eden bir yazarı finansal bir sihirbaza dönüştürür, ancak aynı zamanda onu birçok tehlikeyle dolu yeni bir dünyaya sokar.";
        }

        private void unknownI2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mcr2;
            textBox1.Text = "Bir adam komadan uyandığında, birinin kimliğini aldığını keşfettiğinde, kim olduğunu kanıtlamak için genç bir kadınla birlikte çalışır.";
        }

        private void fastFive2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mcr3;
            textBox1.Text = "Dominic Toretto ve sokak yarışçılarından oluşan ekibi, güçlü bir Brezilyalı uyuşturucu baronu ve tehlikeli bir federal ajanın gözü önündeyken özgürlüklerini satın almak için büyük bir soygun planlıyor.";
        }

        private void transformersDarkOfTheMoon2011ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.mcr4;
            textBox1.Text = "Autobot'lar, Ay'da gizlenmiş bir Cybertronian uzay aracını öğrenir ve ona ulaşmak ve sırlarını öğrenmek için Decepticon'lara karşı yarışır.";
        }

        private void afterEverything2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rmntk1;
            textBox1.Text = "Gerçek aşkından ayrıldıktan sonra, en çok satan yazar Hardin Scott, geçmiş davranışlarını telafi etmek için Portekiz'e gider.";
        }

        private void theLittleMermaidI2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rmntk2;
            textBox1.Text = "Genç bir deniz kızı, suyun üstündeki dünyayı keşfedebilmesi ve bir prensi etkileyebilmesi için güzel sesini insan bacaklarıyla takas etmek için bir deniz cadısı ile anlaşma yapar.";
        }

        private void znachor2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rmntk3;
            textBox1.Text = "Karısının ve sevgili kızının ayrıldığı Profesör Wilczur, alkolde unutulmayı arıyor. Bir soygun girişimi sırasında kafasından ağır yaralandı, hafızasını kaybeder.";
        }

        private void noHardFeelings2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rmntk4;
            textBox1.Text = "Evini kaybetmenin eşiğinde olan Maddie, ilgi çekici bir iş ilanı bulur: 19 yaşındaki içe dönük oğullarını üniversiteden önce kabuğundan çıkaracak birini arayan helikopter ebeveynler. Onu erkek yapmak ya da denerken ölmek için bir yazı var.";
        }

        private void dasBoot1981ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.savas1;
            textBox1.Text = "Bir Alman denizaltısı, Kuzey Atlantik'in soğuk sularında dolaşırken, genç mürettebatı II. Dünya Savaşı'nda bir denizaltının katıksız dehşetini ve klostrofobik hayatını deneyimliyor.";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.savas2;
            textBox1.Text = "6 Nisan 1917. Bir piyade taburu düşman topraklarının derinliklerinde savaşmak için toplanırken, iki asker zamana karşı yarışmak ve 1.600 adamın doğrudan ölümcül bir tuzağa düşmesini engelleyecek bir mesaj iletmek için görevlendirilir.";
        }

        private void laVitaÈBella1997ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.savas3;
            textBox1.Text = "Açık fikirli bir Yahudi garson ve oğlu Holokost'un kurbanı olduklarında, oğlunu kamplarının etrafındaki tehlikelerden korumak için mükemmel bir irade, mizah ve hayal gücü karışımı kullanır.";
        }

        private void apocalypseNow1979ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.savas4;
            textBox1.Text = "Vietnam'da görev yapan bir ABD Ordusu subayı, kendisini bir tanrı olarak gören dönek bir Özel Kuvvetler Albayına suikast düzenlemekle görevlendirilir.";
        }

        private void granTurismo2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.spor1;
            textBox1.Text = "Dünyanın en seçkin sporunu üstlenmek için her şeyi riske atan, mücadele eden, işçi sınıfından bir oyuncu, başarısız bir eski yarış arabası sürücüsü ve idealist bir motor sporları yöneticisi olan bir mazlum ekibinin inanılmaz, ilham verici gerçek hikayesine dayanmaktadır.";
        }

        private void cars2006ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.spor2;
            textBox1.Text = "Hayatının en büyük yarışına giden yolda, ateşli bir çaylak yarış arabası yıkık bir kasabada mahsur kalır ve kazanmanın hayattaki her şey olmadığını öğrenir.";
        }

        private void cargaMáxima2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.spor3;
            textBox1.Text = "Hayatının en büyük yarışına giden yolda, ateşli bir çaylak yarış arabası yıkık bir kasabada mahsur kalır ve kazanmanın hayattaki her şey olmadığını öğrenir.";
        }

        private void theIronClaw2023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.spor4;
            textBox1.Text = "1980'lerin başında profesyonel güreşin yoğun rekabet dünyasında tarih yazan ayrılmaz Von Erich kardeşlerin gerçek hikayesi.";
        }

        private void kingdomOfHeaven2005ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tarih1;
            textBox1.Text = "İbelinli Balian, 12. yüzyıldaki Haçlı Seferleri sırasında Kudüs'e gider ve orada kendisini şehrin ve halkının savunucusu olarak bulur.";
        }

        private void thePianist2002ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tarih2;
            textBox1.Text = "Polonyalı Yahudi bir müzisyen, II. Dünya Savaşı'nda Varşova gettosunun yıkımından sağ çıkmaya çalışıyor.";
        }

        private void laVitaÈBella1997ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tarih3;
            textBox1.Text = "Açık fikirli bir Yahudi garson ve oğlu Holokost'un kurbanı olduklarında, oğlunu kamplarının etrafındaki tehlikelerden korumak için mükemmel bir irade, mizah ve hayal gücü karışımı kullanır.";
        }

        private void piratesOfTheCaribbeanTheCurseOfTheBlackPearl2003ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tarih4;
            textBox1.Text = "Demirci Will Turner, aşkı valinin kızını Jack'in artık ölümsüz olan eski korsan müttefiklerinden kurtarmak için eksantrik korsan \"Kaptan\" Jack Sparrow ile bir araya gelir.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.blackcolor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
