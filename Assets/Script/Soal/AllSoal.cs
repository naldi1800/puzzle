using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSoal
{
    public List<Dictionary<String, dynamic>> get(Soal.TypeSoal typeSoal)
    {
        if (typeSoal == Soal.TypeSoal.RumahAdat) return RumahAdat();
        if (typeSoal == Soal.TypeSoal.TariAdatTradisional) return TariTradisional();
        if (typeSoal == Soal.TypeSoal.BajuAdat) return BajuAdat();
        if (typeSoal == Soal.TypeSoal.AlatMusikTradisional) return AlatMusik();
        if (typeSoal == Soal.TypeSoal.MakananTradisional) return MakananTradisional();
        return null;
    }
    public List<Dictionary<String, dynamic>> RumahAdat()
    {
        return new List<Dictionary<String, dynamic>> {
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah Limas adalah rumah adat dari daerah..." },
                { "answer", "Sumatera Selatan" },
                { "p1", "Sumatera Selatan" },
                { "p2", "Sumatera utara" },
                { "p3", "Jawa tengah" },
                { "p4", "Kalimatan selatan" },
                { "image", false },
            }, // Soal no 1
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Krong Brade berasal dari daerah..." },
                { "answer", "Aceh" },
                { "p1", "Aceh" },
                { "p2", "Sumatera Utara" },
                { "p3", "Sumatera Barat" },
                { "p4", "Riau" },
                { "image", false },
            }, // Soal no 2
            new Dictionary<string, dynamic> {
                { "quiz", "Perhatikan gambar dibawah ini!\nRumah Gadang adalah rumah adat dari provinsi…" },
                { "answer", "Sumatera Barat" },
                { "p1", "Sulawesi Selatan" },
                { "p2", "Maluku" },
                { "p3", "Aceh" },
                { "p4", "Sumatera Barat" },
                { "image", true },
            }, // Soal no 3
            new Dictionary<string, dynamic> {
                { "quiz", "Perhatikan gambar di bawah ini!\nRumah adat di atas berasal dari suku…" },
                { "answer", "Toraja" },
                { "p1", "Jawa" },
                { "p2", "Batak" },
                { "p3", "Sunda" },
                { "p4", "Toraja" },
                { "image", true },
            }, // Soal no 4
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah Bolon adalah rumah adat dari daerah…" },
                { "answer", "Sumatera Utara" },
                { "p1", "Bangka Belitung" },
                { "p2", "Sumatera Utara" },
                { "p3", "Bali" },
                { "p4", "Papua" },
                { "image", false },
            }, // Soal no 5
            new Dictionary<string, dynamic> {
                { "quiz", "Perhatikan gambar dibawah ini!\nGambar diatas termasuk rumah tradisional yang berasal dari daerah NTT adalah…" },
                { "answer", "Rumah adat Kariwari" },
                { "p1", "Rumah adat Musalaki" },
                { "p2", "Rumah adat Kariwari" },
                { "p3", "Rumah adat Tambi" },
                { "p4", "Rumah adat Gadang" },
                { "image", true },
            }, // Soal no 6
            new Dictionary<string, dynamic> {
                { "quiz", "Berikut ini adalah rumah adat yang berasal dari provinsi Jambi…" },
                { "answer", "Panggung" },
                { "p1", "Krong Bade" },
                { "p2", "Bolon" },
                { "p3", "Rumah Gadang" },
                { "p4", "Panggung" },
                { "image", false },
            }, // Soal no 7
            new Dictionary<string, dynamic> {
                { "quiz", "Berikut ini adalah rumah adat yang berasal dari provinsi Bengkulu…" },
                { "answer", "Bubungan Lima" },
                { "p1", "Bubungan Lima" },
                { "p2", "Limas" },
                { "p3", "Nuwo" },
                { "p4", "Badui" },
                { "image", false },
            }, // Soal no 8
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Sasadu berasal dari provinsi…" },
                { "answer", "Maluku Utara" },
                { "p1", "Bangka Belitung" },
                { "p2", "Maluku Utara" },
                { "p3", "Kalimantan timur" },
                { "p4", "Sulawesi barat" },
                { "image", false },
            }, // Soal no 9
            new Dictionary<string, dynamic> {
                { "quiz", "Dibawah ini yang termasuk rumah adat dari Suku Tojara…" },
                { "answer", "Tongkonan" },
                { "p1", "Tongkonan" },
                { "p2", "Badui" },
                { "p3", "Bolon" },
                { "p4", "Rumah Gadang" },
                { "image", false },
            }, // Soal no 10
            new Dictionary<string, dynamic> {
                { "quiz", "Perhatikan gambar dibawah ini!\nGambar diatas merupakan rumah adat Honai yang berasal dari daerah…" },
                { "answer", "Papua" },
                { "p1", "Aceh" },
                { "p2", "Maluku" },
                { "p3", "Sulawesi Selatan" },
                { "p4", "Papua" },
                { "image", true },
            }, // Soal no 11
            new Dictionary<string, dynamic> {
                { "quiz", "Dibawah ini yang termasuk rumah tradisional dari Kalimantan Timur…" },
                { "answer", "Rumah Lamin" },
                { "p1", "Rumah Adat Lamin" },
                { "p2", "Rumah adat Joglo" },
                { "p3", "Rumah Adat panggong" },
                { "p4", "Rumah adat Limas" },
                { "image", false },
            }, // Soal no 12
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah Rakit adalah rumah adat dari daerah…" },
                { "answer", "Bangka Belitung" },
                { "p1", "Papua" },
                { "p2", "Bangka Belitung" },
                { "p3", "DKI Jakarta" },
                { "p4", "Sulawesi Selatan" },
                { "image", false },
            }, // Soal no 13
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah Joglo berasal dari daerah…" },
                { "answer", "Jawa Tengah" },
                { "p1", "Jogyakarta" },
                { "p2", "Jawa Tengah" },
                { "p3", "Sumatra Utara" },
                { "p4", "Bali" },
                { "image", false },
            }, // Soal no 14
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah Panggung Selaso Jatuh Kembar berasal dari daerah…" },
                { "answer", "Jawa Barat" },
                { "p1", "Riau" },
                { "p2", "Sulawesi Utara" },
                { "p3", "Jawa Timur" },
                { "p4", "Jawa Barat" },
                { "image", false },
            }, // Soal no 15
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Kalimantan Selatan adalah…" },
                { "answer", "Rumah Bubungan Tinggi" },
                { "p1", "Rumah Bubungan Tinggi" },
                { "p2", "Rumah batik" },
                { "p3", "Rumah Joglo" },
                { "p4", "Rumah igloo" },
                { "image", false },
            }, // Soal no 16
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat dari Kepulauan Riau adalah…" },
                { "answer", "Rumah Atap Limas Potong" },
                { "p1", "Rumah Atap Limas Potong" },
                { "p2", "Rumah banjar" },
                { "p3", "Rumah limas" },
                { "p4", "Rumah Hanoi" },
                { "image", false },
            }, // Soal no 17
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah joglo merupakan rumah adat dari daerah, kecuali…" },
                { "answer", "Jawa Timur" },
                { "p1", "Jawa Tengah" },
                { "p2", "D.I. Yogyakarta" },
                { "p3", "Jawa barat" },
                { "p4", "Jawa Timur" },
                { "image", false },
            }, // Soal no 18
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat yang hanya digunakan unruk acara adat saja adalah…" },
                { "answer", "Rumah Bubungan Lima" },
                { "p1", "Rumah Bubungan Lima" },
                { "p2", "Rumah Panggung" },
                { "p3", "Rumah Atap Limas Potong" },
                { "p4", "Rumah Limas" },
                { "image", false },
            }, // Soal no 19
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Betawi disebut rumah ..." },
                { "answer", "Rumah Kebaya" },
                { "p1", "Rumah Joglo" },
                { "p2", "Rumah Kebaya" },
                { "p3", "Rumah Panggung" },
                { "p4", "Rumah Tongkonan" },
                { "image", false },
            }, // Soal no 20
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat yang memiliki ciri bentuk atapnya menyerupai dengan ujung melengkung seperti Gajah Mabuk, yaitu ...." },
                { "answer", "Rumah Krong Bade" },
                { "p1", "Rumah Panggung" },
                { "p2", "Rumah Panjang" },
                { "p3", "Rumah Krong Bade" },
                { "p4", "Rumah Honai" },
                { "image", false },
            }, // Soal no 21
            new Dictionary<string, dynamic> {
                { "quiz", "Tujuan rumah adat Honai sengaja dibuat kecil dan tidak berjendela, yaitu ...." },
                { "answer", "Menghindari binatang buas" },
                { "p1", "Menahan hawa panas" },
                { "p2", "Menahan hawa dingin" },
                { "p3", "Menghindari binatang buas" },
                { "p4", "Menghindari serangan suku lain" },
                { "image", false },
            }, // Soal no 22
            new Dictionary<string, dynamic> {
                { "quiz", "Perhatikan gambar dibawah ini!\nGambar diatas termasuk rumah tradisional yang berasal dari daerah Papua adalah…" },
                { "answer", "Rumah Musalaki" },
                { "p1", "Rumah Kariwari" },
                { "p2", "Rumah Banua Tada" },
                { "p3", "Rumah Baileo" },
                { "p4", "Rumah Musalaki" },
                { "image", true },
            }, // Soal no 23
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat buton yang berasal dari daerah Sulawesi Tenggara yang memiliki fungsi…" },
                { "answer", "Sebuah tempat tinggal yang dikhususkan untuk kaum bangsawan atau ketua adat" },
                { "p1", "Sebuah tempat tinggal yang dikhususkan untuk kaum bangsawan atau ketua adat" },
                { "p2", "Tempat tinggal biasa" },
                { "p3", "Tempat upacara" },
                { "p4", "Tempat makan" },
                { "image", false },
                }, // Soal no 24
                new Dictionary<string, dynamic> {
                { "quiz", "Bagaimana bentuk rumah adat Badaui yang berasal dari Banten…" },
                { "answer", "Menyerupai tanduk kerbau" },
                { "p1", "Bundar" },
                { "p2", "Segitiga" },
                { "p3", "Julang Ngpak (panggung)" },
                { "p4", "Menyerupai tanduk kerbau" },
                { "image", false },
            }, // Soal no 25
            new Dictionary<string, dynamic> {
                { "quiz", "Bagaimana bentuk rumah adat Joglo yang berasal dari daerah Jawa Tengah…" },
                { "answer", "Berbentuk limas atau gepak" },
                { "p1", "Dengan ciri atap berbentuk piramida yang mengacu pada bentuk gunung" },
                { "p2", "Panggung" },
                { "p3", "Berbentuk limas atau gepak" },
                { "p4", "Berbentuk bundar" },
                { "image", false },
            }, // Soal no 26
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Gapura Candi Bentar merupakan rumah adat yang berasal dari…" },
                { "answer", "Bali" },
                { "p1", "Sulawesi Selatan" },
                { "p2", "Aceh" },
                { "p3", "Lampung" },
                { "p4", "Bali" },
                { "image", false },
            }, // Soal no 27
            new Dictionary<string, dynamic> {
                { "quiz", "Apa fungsi batu besar yang ada di bawah rumah musalaki, yaitu…" },
                { "answer", "Terhindar dari hewan buas" },
                { "p1", "Terhindar dari hewan buas" },
                { "p2", "Terhindar dari banjir" },
                { "p3", "Mengurangi risiko keretakan" },
                { "p4", "Mengurangi pemakaian tiang" },
                { "image", false },
            }, // Soal no 28
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Dalam Loka yang berasal dari NTB, berapa tiang rumah adat tersebut yang melambangkan sifat Allah…" },
                { "answer", "99 tiang" },
                { "p1", "100 tiang" },
                { "p2", "20 tiang" },
                { "p3", "99 tiang" },
                { "p4", "10 tiang" },
                { "image", false },
            }, // Soal no 29
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Bengkulu disebut rumah ..." },
                { "answer", "Rumah Bubungan Lima" },
                { "p1", "Rumah Panggung" },
                { "p2", "Rumah Limas" },
                { "p3", "Rumah Bubungan Lima" },
                { "p4", "Rumah Joglo" },
                { "image", false },
            }, // Soal no 30
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Panggung berasal dari daerah..." },
                { "answer", "Jambi" },
                { "p1", "Riau" },
                { "p2", "Bengkulu" },
                { "p3", "Aceh" },
                { "p4", "Jambi" },
                { "image", false },
            }, // Soal no 31
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Lampung disebut rumah..." },
                { "answer", "Rumah Bubungan Lima" },
                { "p1", "Rumah Atap Limas Potong" },
                { "p2", "Rumah Bubungan Lima" },
                { "p3", "Rumah Panggung" },
                { "p4", "Rumah Nuwo Sesat" },
                { "image", false },
            }, // Soal no 32
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Limas berasal dari daerah..." },
                { "answer", "Sumatera Selatan" },
                { "p1", "Sumatera Selatan" },
                { "p2", "Sumatera Utara" },
                { "p3", "Bengkulu" },
                { "p4", "Bangka Belitung" },
                { "image", false },
            }, // Soal no 33
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Jawa Barat disebut rumah..." },
                { "answer", "Rumah Kasepuhan" },
                { "p1", "Rumah Kasepuhan" },
                { "p2", "Rumah Kebaya" },
                { "p3", "Rumah Baduy" },
                { "p4", "Rumah Rakit" },
                { "image", false },
            }, // Soal no 34
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Panjang berasal dari daerah..." },
                { "answer", "Kalimantan Barat" },
                { "p1", "Jawa Timur" },
                { "p2", "Kalimantan Barat" },
                { "p3", "Jawa Tengah" },
                { "p4", "Kalimantan Tengah" },
                { "image", false },
            }, // Soal no 35
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Kalimantan Timur disebut rumah..." },
                { "answer", "Rumah Lamin" },
                { "p1", "Rumah Panjang" },
                { "p2", "Rumah Lamin" },
                { "p3", "Rumah Kasepuhan" },
                { "p4", "Rumah Baduy" },
                { "image", false },
            }, // Soal no 36
            new Dictionary<string, dynamic> {
                { "quiz", "Ornamen yang ada pada bagian atap Rumah Lamin Kalimantan Timur adalah..." },
                { "answer", "Kepala Naga" },
                { "p1", "Ayam" },
                { "p2", "Kepala Kerbau" },
                { "p3", "Kepala Naga" },
                { "p4", "Tanduk Banteng" },
                { "image", false },
            }, // Soal no 37
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Betang berasal dari daerah..." },
                { "answer", "Kalimantan Tengah" },
                { "p1", "Aceh" },
                { "p2", "Bali" },
                { "p3", "Kalimantan Tengah" },
                { "p4", "Papua" },
                { "image", false },
            }, // Soal no 38
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Kalimantan Utara disebut rumah..." },
                { "answer", "Rumah Bubungan Tinggi" },
                { "p1", "Rumah Betang" },
                { "p2", "Rumah Bubungan Tinggi" },
                { "p3", "Rumah Lamin" },
                { "p4", "Rumah Baloy" },
                { "image", false },
            }, // Soal no 39
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah unik yang harus menghadap ke utara dan pintu utamanya di arah selatan berasal dari daerah..." },
                { "answer", "Jambi" },
                { "p1", "Sumatera Barat" },
                { "p2", "Jambi" },
                { "p3", "Jawa Tengah" },
                { "p4", "Kalimantan Utara" },
                { "image", false },
            }, // Soal no 40
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Dulohupa berasal dari daerah..." },
                { "answer", "Nusa Tenggara Timur" },
                { "p1", "Gorontalo" },
                { "p2", "Bengkulu" },
                { "p3", "Papua" },
                { "p4", "Nusa Tenggara Timur" },
                { "image", false },
            }, // Soal no 41
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Sulawesi Barat disebut rumah..." },
                { "answer", "Rumah Boyang" },
                { "p1", "Rumah Boyang" },
                { "p2", "Rumah Joglo" },
                { "p3", "Rumah Kebaya" },
                { "p4", "Rumah Rakit" },
                { "image", false },
            }, // Soal no 42
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Souraja berasal dari daerah..." },
                { "answer", "Sulawesi Tengah" },
                { "p1", "Riau" },
                { "p2", "Sulawesi Tengah" },
                { "p3", "Kalimantan Timur" },
                { "p4", "Papua" },
                { "image", false },
            }, // Soal no 43
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Sulawesi Utara disebut rumah..." },
                { "answer", "Rumah Tongkonan" },
                { "p1", "Rumah Souraja" },
                { "p2", "Rumah Walewangko" },
                { "p3", "Rumah Tongkonan" },
                { "p4", "Rumah Gadang" },
                { "image", false },
            }, // Soal no 44
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Baileo berasal dari daerah..." },
                { "answer", "Maluku" },
                { "p1", "Kepulauan Riau" },
                { "p2", "Bangka Belitung" },
                { "p3", "Maluku" },
                { "p4", "Papua" },
                { "image", false },
            }, // Soal no 45
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Maluku Utara disebut rumah..." },
                { "answer", "Rumah Baileo" },
                { "p1", "Rumah Baileo" },
                { "p2", "Rumah Musalaki" },
                { "p3", "Rumah Sasadu" },
                { "p4", "Rumah Kariwari" },
                { "image", false },
            }, // Soal no 46
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Kariwari berasal dari daerah..." },
                { "answer", "Papua" },
                { "p1", "Gorontalo" },
                { "p2", "Bali" },
                { "p3", "DKI Jakarta" },
                { "p4", "Papua" },
                { "image", false },
            }, // Soal no 47
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Papua Barat disebut rumah..." },
                { "answer", "Rumah Mod Aki Aksa" },
                { "p1", "Rumah Limas" },
                { "p2", "Rumah Rakit" },
                { "p3","Rumah Tongkonan" },
                { "p4", "Rumah Mod Aki Aksa" },
                { "image", false },
            }, // Soal no 48
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Hanoi berasal dari daerah..." },
                { "answer", "NTT" },
                { "p1", "Papua" },
                { "p2", "NTT" },
                { "p3", "NTB" },
                { "p4", "Maluku" },
                { "image", false },
            }, // Soal no 49
            new Dictionary<string, dynamic> {
                { "quiz", "Rumah adat Papua Selatan disebut rumah..." },
                { "answer", "Rumah Karapao" },
                { "p1", "Rumah Jew" },
                { "p2", "Rumah Hanoi" },
                { "p3", "Rumah Karapao" },
                { "p4", "Rumah Kariwari" },
                { "image", false },
            }, // Soal no 50
        };
    }
    public List<Dictionary<String, dynamic>> TariTradisional()
    {
        return new List<Dictionary<String, dynamic>>{
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berikut ini adalah tarian yang berasal dari daerah Sumatera Utara..."},
                {"answer", "Tari tor-tor"},
                {"p1", "Tari saman"},
                {"p2", "Tari tor-tor"},
                {"p3", "Tari enggang"},
                {"p4", "Tari monong"},
                {"image", false},
                {"comment", "Soal no 1"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari cakalele berasal dari daerah..."},
                {"answer", "Maluku"},
                {"p1", "Maluku"},
                {"p2", "Jawa Barat"},
                {"p3", "Sulawesi Utara"},
                {"p4", "Kalimantan Tengah"},
                {"image", false},
                {"comment", "Soal no 2"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Siti dan teman-temanya sedang berlatih tari tradisional dari suku Aceh yang bernama..."},
                {"answer", "Tari saman"},
                {"p1", "Tari saman"},
                {"p2", "Tari piring"},
                {"p3", "Tari kecak"},
                {"p4", "Tari selamat datang"},
                {"image", false},
                {"comment", "Soal no 3"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari kipas berasal dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sumatra Utara"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "NTT"},
                {"p4", "Kalimantan Utara"},
                {"image", false},
                {"comment", "Soal no 4"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari daerah yang berasal dari daerah Jambi adalah..."},
                {"answer", "Tari Sekapur Sirih"},
                {"p1", "Tari Gambyong"},
                {"p2", "Tari Jaipong"},
                {"p3", "Tari Balumpa"},
                {"p4", "Tari Sekapur Sirih"},
                {"image", false},
                {"comment", "Soal no 5"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan gambar dibawah ini!\n\nTari cerana adalah tari adat dari daerah..."},
                {"answer", "Papua"},
                {"p1", "Maluku"},
                {"p2", "Papua"},
                {"p3", "Sulawesi Selatan"},
                {"p4", "NTT"},
                {"image", true},
                {"comment", "Soal no 6"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Topeng dipentaskan dalam berapa orang yang mengenakan beberapa jenis topeng berjumlah..."},
                {"answer", "4 orang"},
                {"p1", "4 orang"},
                {"p2", "6 orang"},
                {"p3", "5 orang"},
                {"p4", "10 orang"},
                {"image", false},
                {"comment", "Soal no 7"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Jenis tari berikut ini yang mengisahkan tentang cinta kasih yaitu tari..."},
                {"answer", "Tari saudati"},
                {"p1", "Tari jaipong"},
                {"p2", "Tari saudati"},
                {"p3", "Tari inai"},
                {"p4", "Tari serampang 12"},
                {"image", false},
                {"comment", "Soal no 8"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Jaipong merupakan tarian yang berasal dari daerah..."},
                {"answer", "Jawa Barat"},
                {"p1", "Sumatra Barat"},
                {"p2", "Jawa Tengah"},
                {"p3", "Jawa Barat"},
                {"p4", "Jawa Timur"},
                {"image", false},
                {"comment", "Soal no 9"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari yang diringi dengan gamelan dinamakan tari..."},
                {"answer", "Tari piring"},
                {"p1", "Tari Mentawai"},
                {"p2", "Tari seriping"},
                {"p3", "Tari jaipong"},
                {"p4", "Tari piring"},
                {"image", false},
                {"comment", "Soal no 10"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari yang berasal dari Sumatra Barat yang ditarikan berpasangan dan bermakna wujud perlindungan dan kasih sayang seorang kekasih pada pasangannya adalah tari..."},
                {"answer", "Tari payung"},
                {"p1", "Tari cakalele"},
                {"p2", "Tari pedang"},
                {"p3", "Tari perang"},
                {"p4", "Tari payung"},
                {"image", false},
                {"comment", "Soal no 11"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari pakarena merupakan tari khas Sulawesi. Tari ini melambangkan kecantikan Sulawesi. Tari ini sangat dikenal dengan propertinya, yaitu..."},
                {"answer", "Kipas"},
                {"p1", "Kipas"},
                {"p2", "Keris"},
                {"p3", "Cundrik"},
                {"p4", "Tameng"},
                {"image", false},
                {"comment", "Soal no 12"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari-tarian daerah pada masa sekarang ini banyak digunakan untuk acara..."},
                {"answer", "Penyambutan tamu"},
                {"p1", "Keagamaan"},
                {"p2", "Sesaji"},
                {"p3", "Penyambutan tamu"},
                {"p4", "Syukran"},
                {"image", false},
                {"comment", "Soal no 13"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari merak berasal dari daerah..."},
                {"answer", "Jawa Barat"},
                {"p1", "Bali"},
                {"p2", "Banten"},
                {"p3", "Jawa Barat"},
                {"p4", "Sumatera Selatan"},
                {"image", false},
                {"comment", "Soal no 14"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari saman merupakan tarian dari daerah..."},
                {"answer", "Aceh"},
                {"p1", "Jawa Barat"},
                {"p2", "Kalimantan"},
                {"p3", "Aceh"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 15"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berikut ini adalah tari-tari dari daerah Jawa Tengah, kecuali..."},
                {"answer", "Jaipong"},
                {"p1", "Beksan Wireng"},
                {"p2", "Jaipong"},
                {"p3", "Gamboyong"},
                {"p4", "Bedaya"},
                {"image", false},
                {"comment", "Soal no 16"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari topeng merupakan tarian dari daerah..."},
                {"answer", "Jawa Tengah"},
                {"p1", "DKI Jakarta"},
                {"p2", "Kalimantan"},
                {"p3", "Aceh"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 17"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari ketuk tilu berasal dari provinsi..."},
                {"answer", "Jawa Barat"},
                {"p1", "Riau"},
                {"p2", "Jawa Tengah"},
                {"p3", "Jawa Barat"},
                {"p4", "Jawa Timur"},
                {"image", false},
                {"comment", "Soal no 18"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari zapin berasal dari daerah..."},
                {"answer", "Riau"},
                {"p1", "Jawa Barat"},
                {"p2", "Riau"},
                {"p3", "Sumatera Utara"},
                {"p4", "NTT"},
                {"image", false},
                {"comment", "Soal no 19"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan gambar dibawah ini!\n\nGambar diatas termasuk tari yang berasal dari daerah NTB adalah..."},
                {"answer", "Tari Piring"},
                {"p1", "Tari Tor-tor"},
                {"p2", "Tari Kecap"},
                {"p3", "Tari Piring"},
                {"p4", "Tari Mpaa Lenggon"},
                {"image", true},
                {"comment", "Soal no 20"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari bungong jeumpa merupakan tarian daerah yang berasal dari..."},
                {"answer", "Aceh"},
                {"p1", "Aceh"},
                {"p2", "Sumatera Utara"},
                {"p3", "Sumatera Barat"},
                {"p4", "Riau"},
                {"image", false},
                {"comment", "Soal no 21"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari ketuk tilu dipentaskan dalam berapa orang penari..."},
                {"answer", "6 orang"},
                {"p1", "4 orang"},
                {"p2", "6 orang"},
                {"p3", "12 orang"},
                {"p4", "10 orang"},
                {"image", false},
                {"comment", "Soal no 22"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari andun berasal dari daerah..."},
                {"answer", "Jawa Barat"},
                {"p1", "DKI Jakarta"},
                {"p2", "Jawa Barat"},
                {"p3", "Jawa Tengah"},
                {"p4", "Bengkulu"},
                {"image", false},
                {"comment", "Soal no 23"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari gambyong merupakan tari yang berasal dari daerah Jawa Tengah, tari ini bertujuan untuk..."},
                {"answer", "Upacara ritual pertanian yang bertujuan untuk kesuburan padi"},
                {"p1", "Upacara kematian"},
                {"p2", "Upacara penjemput"},
                {"p3", "Upacara ritual pertanian yang bertujuan untuk kesuburan padi"},
                {"p4", "Upacara pernikahan"},
                {"image", false},
                {"comment", "Soal no 24"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari pakarrena merupakan tari yang berasal dari Sulawesi Selatan, tari ini menceritakan tentang..."},
                {"answer", "Tentang perpisahan dunia kayangan dan bumi"},
                {"p1", "Menceritakan pergaulan remaja"},
                {"p2", "Menceritakan tentang burung elang"},
                {"p3", "Tentang penjajahan"},
                {"p4", "Tentang perpisahan dunia kayangan dan bumi"},
                {"image", false},
                {"comment", "Soal no 25"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Reog Ponorogo merupakan tari yang berasal dari Jawa Timur, tari ini menceritakan tentang..."},
                {"answer", "Tari ini mengisahkan bagaimana Ki Ajeng Mutu melawan Raja Kertabhumi dan seisi kerajaannya"},
                {"p1", "Tari ini mengisahkan bagaimana Ki Ajeng Mutu melawan Raja Kertabhumi dan seisi kerajaannya"},
                {"p2", "Tari ini mengisahkan bagaimana berbicara dengan roh"},
                {"p3", "Tentang penjajahan"},
                {"p4", "Menceritakan pergaulan remaja"},
                {"image", false},
                {"comment", "Soal no 26"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan gambar dibawah ini!\n\nGambar diatas merupakan tari Sekapur Siri yang berasal dari daerah..."},
                {"answer", "Jambi"},
                {"p1", "Jawa Barat"},
                {"p2", "Jawa Tengah"},
                {"p3", "Jambi"},
                {"p4", "Aceh"},
                {"image", true},
                {"comment", "Soal no 27"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari dana-dana berasal dari daerah..."},
                {"answer", "Gorontalo"},
                {"p1", "Gorontalo"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "DKI Jakarta"},
                {"p4", "Aceh"},
                {"image", false},
                {"comment", "Soal no 28"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan gambar dibawah ini!\n\nGambar diatas merupakan tari Dero yang berasal dari daerah..."},
                {"answer", "Sulawesi Tengah"},
                {"p1", "Sumatera Selatan"},
                {"p2", "Sulawesi Tengah"},
                {"p3", "Sulawesi Barat"},
                {"p4", "Sulawesi Selatan"},
                {"image", true},
                {"comment", "Soal no 29"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Kabasaran berasal dari daerah..."},
                {"answer", "Sulawesi Utara"},
                {"p1", "Maluku"},
                {"p2", "Sulawesi Utara"},
                {"p3", "Sumatera Selatan"},
                {"p4", "Sulawesi Tengah"},
                {"image", false},
                {"comment", "Soal no 30"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Kecak, Tari Pendet, dan Tari Legong berasal dari daerah..."},
                {"answer", "Bali"},
                {"p1", "Maluku"},
                {"p2", "Bali"},
                {"p3", "Jawa Tengah"},
                {"p4", "Riau"},
                {"image", false},
                {"comment", "Soal no 31"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Bungong Jeumpa, Saman, dan Tari Ranup Lampuan berasal dari daerah..."},
                {"answer", "Aceh"},
                {"p1", "Aceh"},
                {"p2", "Jambi"},
                {"p3", "Riau"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 32"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Kancet Ledo/Tari Gong berasal dari daerah..."},
                {"answer", "Kalimantan Selatan"},
                {"p1", "Kalimantan Timur"},
                {"p2", "Kalimantan Selatan"},
                {"p3", "Kalimantan Utara"},
                {"p4", "Kalimantan Barat"},
                {"image", false},
                {"comment", "Soal no 33"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Tempurung berasal dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sulawesi Utara"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Sulawesi Tengah"},
                {"p4", "Sulawesi Barat"},
                {"image", false},
                {"comment", "Soal no 34"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Gandrung Lombok berasal dari daerah..."},
                {"answer", "Nusa Tenggara Barat"},
                {"p1", "Nusa Tenggara Barat"},
                {"p2", "Nusa Tenggara Timur"},
                {"p3", "Papua"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 35"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Indung, Tari Piring, dan Tari Lilin berasal dari daerah..."},
                {"answer", "Sumatera Barat"},
                {"p1", "Sumatera Barat"},
                {"p2", "Sumatera Selatan"},
                {"p3", "Sumatera Utara"},
                {"p4", "Kepulauan Riau"},
                {"image", false},
                {"comment", "Soal no 36"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tarian yang penarinya mencambuk satu sama lain disebut tarian..."},
                {"answer", "Tari Caci"},
                {"p1", "Tari Caci"},
                {"p2", "Tari Tempurung"},
                {"p3", "Tari Gandrung Lombok"},
                {"p4", "Tari Pring"},
                {"image", false},
                {"comment", "Soal no 37"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Caci berasal dari daerah..."},
                {"answer", "Nusa Tenggara Timur"},
                {"p1", "Nusa Tenggara Timur"},
                {"p2", "Nusa Tenggara Barat"},
                {"p3", "Papua"},
                {"p4", "Sulawesi Tenggara"},
                {"image", false},
                {"comment", "Soal no 38"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Lego Lego berasal dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Nusa Tenggara Timur"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Sumatera Barat"},
                {"p4", "Kalimantan Utara"},
                {"image", false},
                {"comment", "Soal no 39"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Caci dan Tari Lego Lego berasal dari daerah..."},
                {"answer", "Nusa Tenggara Timur"},
                {"p1", "Nusa Tenggara Timur"},
                {"p2", "Sulawesi Barat"},
                {"p3", "Sumatera Utara"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 40"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Tide Tide berasal dari daerah..."},
                {"answer", "Maluku Utara"},
                {"p1", "Maluku Utara"},
                {"p2", "Sulawesi Tenggara"},
                {"p3", "Sumatera Selatan"},
                {"p4", "Kalimantan Timur"},
                {"image", false},
                {"comment", "Soal no 41"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tarian Tide Tide yang berasal dari Maluku Utara merupakan salah satu tarian daerah yang menggambarkan..."},
                {"answer", "Pergaulan antara Wanita dan Pria"},
                {"p1", "Pergaulan antara Wanita dan Pria"},
                {"p2", "Perjuangan"},
                {"p3", "Peperangan"},
                {"p4", "Panen"},
                {"image", false},
                {"comment", "Soal no 42"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Saureka Reka berasal dari daerah..."},
                {"answer", "Jambi"},
                {"p1", "Maluku"},
                {"p2", "Jawa Timur"},
                {"p3", "Jawa Tengah"},
                {"p4", "Jambi"},
                {"image", false},
                {"comment", "Soal no 43"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berapakah jumlah penari laki-laki dan perempuan dalam Tarian Saureka Reka..."},
                {"answer", "4 Laki-laki dan 4 Perempuan"},
                {"p1", "4 Laki-laki dan 4 Perempuan"},
                {"p2", "5 Laki-laki dan 5 Perempuan"},
                {"p3", "6 Laki-laki dan 6 Perempuan"},
                {"p4", "7 Laki-laki dan 7 Perempuan"},
                {"image", false},
                {"comment", "Soal no 44"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Awaijale RileJale berasal dari daerah..."},
                {"answer", "Jambi"},
                {"p1", "Papua"},
                {"p2", "Bali"},
                {"p3", "Riau"},
                {"p4", "Jambi"},
                {"image", false},
                {"comment", "Soal no 45"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Selamat Datang berasal dari daerah..."},
                {"answer", "Bali"},
                {"p1", "Papua Timur"},
                {"p2", "Sulawesi Tengah"},
                {"p3", "Bali"},
                {"p4", "DKI Jakarta"},
                {"image", false},
                {"comment", "Soal no 46"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Sajojo berasal dari daerah..."},
                {"answer", "Papua"},
                {"p1", "Papua"},
                {"p2", "Nusa Tenggara Timur"},
                {"p3", "Nusa Tenggara Barat"},
                {"p4", "Yogyakarta"},
                {"image", false},
                {"comment", "Soal no 47"}
            },new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Yospan berasal dari daerah..."},
                {"answer", "Papua"},
                {"p1", "Papua"},
                {"p2", "Bangka Belitung"},
                {"p3", "Banten"},
                {"p4", "Jawa Barat"},
                {"image", false},
                {"comment", "Soal no 48"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Awaijale Rilejale, Tari Sajojo, dan Tari Yospan berasal dari daerah..."},
                {"answer", "Papua"},
                {"p1", "Papua"},
                {"p2", "Jawa Barat"},
                {"p3", "Jawa Timur"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 49"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tari Rnup Lampuan berasal dari daerah..."},
                {"answer", "Aceh"},
                {"p1", "Aceh"},
                {"p2", "Riau"},
                {"p3", "Jambi"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 50"}
            },
        };
    }
    public List<Dictionary<String, dynamic>> BajuAdat()
    {
        return new List<Dictionary<string, dynamic>>
        {
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan Gambar dibawah ini!\nPakaian adat seperti gambar disamping berasal dari provinsi…"},
                {"answer", "Jawa Barat"},
                {"p1", "Lampung"},
                {"p2", "DKI Jakarta"},
                {"p3", "Jawa Barat"},
                {"p4", "Jawa Tengah"},
                {"image", true},
                {"comment", "Soal no 1"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan gambar dibawah ini!\nSebutkan nama pakain adat dari Aceh pada gambar disamping…"},
                {"answer", "Elee balang"},
                {"p1", "Ulas"},
                {"p2", "Pakaian"},
                {"p3", "Aesan gede"},
                {"p4", "Elee balang"},
                {"image", true},
                {"comment", "Soal no 2"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Perhatikan gambar dibawah ini!\nPakian adat disamping berasal dari…"},
                {"answer", "Sulawesi selatan"},
                {"p1", "Jambi"},
                {"p2", "Aceh"},
                {"p3", "Sulawesi selatan"},
                {"p4", "Sulawesi utara"},
                {"image", true},
                {"comment", "Soal no 3"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Pakaian adat Babu Ngawi berasal dari provinsi…"},
                {"answer", "Sulawesi Tenggara"},
                {"p1", "Sulawesi Selatan"},
                {"p2", "Sulawesi Tenggara"},
                {"p3", "Sulawesi utara"},
                {"p4", "Kalimantan"},
                {"image", false},
                {"comment", "Soal no 4"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Pakaian adat kesatrian ageng berasal dari provinsi…"},
                {"answer", "Istimewa Yogyakarta"},
                {"p1", "Jawa Timur"},
                {"p2", "Jawa Barat"},
                {"p3", "Istimewa Yogyakarta"},
                {"p4", "Banten"},
                {"image", false},
                {"comment", "Soal no 5"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Pakaian adat kebaya laboh dan kurung cekak musang berasal dari provinsi…"},
                {"answer", "Riau"},
                {"p1", "Riau"},
                {"p2", "Jambi"},
                {"p3", "Aceh"},
                {"p4", "Bangka Belitung"},
                {"image", false},
                {"comment", "Soal no 6"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berikut ini adalah pakaian adat yang berasal dari Bali…"},
                {"answer", "Payas Agung"},
                {"p1", "Pegon"},
                {"p2", "Amarasi"},
                {"p3", "Payas Agung"},
                {"p4", "Upak Nyamu"},
                {"image", false},
                {"comment", "Soal no 7"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berikut ini adalah pakian adat yang berasal dari provinsi Kalimatan Timur…"},
                {"answer", "Kustin"},
                {"p1", "Kustin"},
                {"p2", "Pattuqduq"},
                {"p3", "Laku tepu"},
                {"p4", "Upak Nyamu"},
                {"image", false},
                {"comment", "Soal no 8"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Baju adat yang dipenuhi hiasan benag emas yang melambangkan kekayaan Minangkabau disebut"},
                {"answer", "Batabue"},
                {"p1", "Batabue"},
                {"p2", "Batabua"},
                {"p3", "Batabea"},
                {"p4", "Batubea"},
                {"image", false},
                {"comment", "Soal no 9"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Pakaian manteren lamo adalah pakaian adat dari daerah"},
                {"answer", "Maluku Utara"},
                {"p1", "Sulawesi Selatan"},
                {"p2", "Maluku Utara"},
                {"p3", "Sulawesi Tenggara"},
                {"p4", "Maluku"},
                {"image", false},
                {"comment", "Soal no 10"}
            },
            new Dictionary<string, dynamic>
    {
        {"quiz", "Pakaian adat dari daerah Maluku adalah..."},
        {"answer", "Baju cele"},
        {"p1", "Kebaya jawa"},
        {"p2", "Baju cele"},
        {"p3", "Baju bodo"},
        {"p4", "Pakaian mantere lamo"},
        {"image", false},
        {"comment", "Soal no 11"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Ulos salah satu pakaian adat dari daerah..."},
        {"answer", "Sumatera Utara"},
        {"p1", "Sumatera Utara"},
        {"p2", "Sumatera Selatan"},
        {"p3", "Sulawesi Selatan"},
        {"p4", "Jawa Tengah"},
        {"image", false},
        {"comment", "Soal no 12"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju kurung pakaian adat yang berasal dari provinsi..."},
        {"answer", "Jambi"},
        {"p1", "Bangka Belitung"},
        {"p2", "Jambi"},
        {"p3", "Lampung"},
        {"p4", "DKI Jakarta"},
        {"image", false},
        {"comment", "Soal no 13"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Kebaya encim pakaian adat dari daerah..."},
        {"answer", "DKI Jakarta"},
        {"p1", "DKI Jakarta"},
        {"p2", "Sulawesi Selatan"},
        {"p3", "Lampung"},
        {"p4", "Jambi"},
        {"image", false},
        {"comment", "Soal no 14"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Perhatikan gambar dibawah ini!\n\nGambar diatas merupakan baju adat jawi jangkep yang berasal dari daerah..."},
        {"answer", "Sulawesi Selatan"},
        {"p1", "Sulawesi Selatan"},
        {"p2", "Sulawesi Utara"},
        {"p3", "Jambi"},
        {"p4", "Jawa Tengah"},
        {"image", true},
        {"comment", "Soal no 15"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Salah satu pakaian adat suku Batak yang dipakai oleh pria sebagai penutup kepala adalah..."},
        {"answer", "Parompa"},
        {"p1", "Bulang-bulang"},
        {"p2", "Hoba-hoba"},
        {"p3", "Parompa"},
        {"p4", "Jimat"},
        {"image", false},
        {"comment", "Soal no 16"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Kemeja putih pria Bali yang sering dikenakan saat pergi ke pura atau bersembahyang merupakan simbol..."},
        {"answer", "Kesucian"},
        {"p1", "Kesucian"},
        {"p2", "Kematian"},
        {"p3", "Gagah"},
        {"p4", "Indah"},
        {"image", false},
        {"comment", "Soal no 17"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Berikut ini adalah contoh pakaian adat yang benar sesuai daerah asalnya adalah..."},
        {"answer", "Beskap dari Sumatra Utara"},
        {"p1", "Ulos dari Jawa Barat"},
        {"p2", "Beskap dari Sumatra Utara"},
        {"p3", "Baju Kurung dari Sumatra Barat"},
        {"p4", "Kebaya dari Kalimantan Selatan"},
        {"image", false},
        {"comment", "Soal no 18"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Pakaian adat wanita minang disebut..."},
        {"answer", "Limpahpeh nan gadang"},
        {"p1", "Limpahpeh rumah nan gadang"},
        {"p2", "Limpahpeh nan gadang"},
        {"p3", "Limpahpeh nan rumah gadang"},
        {"p4", "Limpahpeh dan rumah nan gadang"},
        {"image", false},
        {"comment", "Soal no 19"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Pakaian adat daerah manakah yang memiliki penutup kepala berbentuk menyerupai tanduk kerbau?"},
        {"answer", "Nusa Tenggara Barat"},
        {"p1", "Papua Barat"},
        {"p2", "Nusa Tenggara Barat"},
        {"p3", "Sulawesi Barat"},
        {"p4", "Sumatera Barat"},
        {"image", false},
        {"comment", "Soal no 20"}
    } ,new Dictionary<string, dynamic>
    {
        {"quiz", "Warna pakaian adat Paksian yang berasal dari provinsi Bangka Belitung..."},
        {"answer", "Warna coklat dan hijau"},
        {"p1", "Warna kuning"},
        {"p2", "Warna hitam"},
        {"p3", "Warna coklat dan hijau"},
        {"p4", "Warna merah dan kuning keemasan"},
        {"image", false},
        {"comment", "Soal no 21"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Pakaian adat Pesa’an dari daerah Madura, Jawa Timur mencerminkan karakter..."},
        {"answer", "Berani, kuat, dan tegas"},
        {"p1", "Berani, kuat, dan tegas"},
        {"p2", "Cantik"},
        {"p3", "Berani"},
        {"p4", "Cantik dan Gagah"},
        {"image", false},
        {"comment", "Soal no 22"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Pegon adalah pakaian adat Indonesia dari provinsi Nusa Tenggara Barat yang terbuat dari..."},
        {"answer", "Kain songket dan kain pegon yang berwarna hitam"},
        {"p1", "Kain tenun"},
        {"p2", "Kain polos"},
        {"p3", "Kain songket dan kain pegon yang berwarna hitam"},
        {"p4", "Kain tenun dan polos"},
        {"image", false},
        {"comment", "Soal no 23"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Upak Nyamu adalah pakaian adat Indonesia dari provinsi Kalimantan Tengah yang terbuat dari..."},
        {"answer", "Kulit kayu nyamu"},
        {"p1", "Kain songket"},
        {"p2", "Kain tenun"},
        {"p3", "Kain satin"},
        {"p4", "Kulit kayu nyamu"},
        {"image", false},
        {"comment", "Soal no 24"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Apa nama pakaian adat ini merupakan busana adat perempuan yang terdiri dari ikat kepala yang terbuat dari panda."},
        {"answer", "Pakaian Nggembe"},
        {"p1", "Pakaian Ta’a"},
        {"p2", "Pakaian Kustin"},
        {"p3", "Pakaian Nggembe"},
        {"p4", "Pakaian Kebaya"},
        {"image", false},
        {"comment", "Soal no 25"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Laku tepu adalah pakaian adat yang berasal dari daerah..."},
        {"answer", "Sulawesi Selatan"},
        {"p1", "Sulawesi Selatan"},
        {"p2", "Sulawesi Barat"},
        {"p3", "Sulawesi Utara"},
        {"p4", "Jawa Barat"},
        {"image", false},
        {"comment", "Soal no 26"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Gorontalo memiliki 4 jenis warna yaitu..."},
        {"answer", "Kuning, ungu, dan abu"},
        {"p1", "Kuning, ungu, dan abu"},
        {"p2", "Merah, hitam, dan kuning"},
        {"p3", "Kuning, coklat, dan abu"},
        {"p4", "Hijau, merah, dan kuning keemasan"},
        {"image", false},
        {"comment", "Soal no 27"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Ewer merupakan pakaian adat khas Papua Barat yang terbuat dari..."},
        {"answer", "Kain tenun"},
        {"p1", "Kulit kayu"},
        {"p2", "Jerami yang dikeringkan"},
        {"p3", "Kain tenun"},
        {"p4", "Kain polos"},
        {"image", false},
        {"comment", "Soal no 28"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Pakaian adat dari provinsi Papua Selatan yang digunakan pria adalah Pummi, rok yang terbuat dari..."},
        {"answer", "Dari anyaman sagu"},
        {"p1", "Jerami yang dikeringkan"},
        {"p2", "Kain sutra"},
        {"p3", "Kulit kayu dikeringkan"},
        {"p4", "Dari anyaman sagu"},
        {"image", false},
        {"comment", "Soal no 29"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Amarasi berasal dari daerah..."},
        {"answer", "Nusa Tenggara Timur"},
        {"p1", "Nusa Tenggara Barat"},
        {"p2", "Nusa Tenggara Timur"},
        {"p3", "Maluku"},
        {"p4", "Papua"},
        {"image", false},
        {"comment", "Soal no 30"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Bundo Kaduang berasal dari daerah..."},
        {"answer", "Sumatera Barat"},
        {"p1", "Sumatera Utara"},
        {"p2", "Jawa Tengah"},
        {"p3", "Sumatera Barat"},
        {"p4", "Kalimantan Utara"},
        {"image", false},
        {"comment", "Soal no 31"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Nggemben berasal dari daerah..."},
        {"answer", "Aceh"},
        {"p1", "Aceh"},
        {"p2", "Riau"},
        {"p3", "Bali"},
        {"p4", "Sulawesi Tengah"},
        {"image", false},
        {"comment", "Soal no 32"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Berasal dari manakah baju adat yang hanya dapat dipergunakan para kaum bangsawan saja, yaitu..."},
        {"answer", "Sumatera Barat"},
        {"p1", "Sumatera Selatan"},
        {"p2", "Sumatera Utara"},
        {"p3", "Sumatera Barat"},
        {"p4", "Kalimantan Utara"},
        {"image", false},
        {"comment", "Soal no 33"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Pakaian adat Teluk Balanga berasal dari daerah..."},
        {"answer", "Kepulauan Riau"},
        {"p1", "Bengkulu"},
        {"p2", "Kepulauan Riau"},
        {"p3", "Jambi"},
        {"p4", "Bangka Belitung"},
        {"image", false},
        {"comment", "Soal no 34"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Betabur berasal dari daerah..."},
        {"answer", "Lampung"},
        {"p1", "Lampung"},
        {"p2", "Banten"},
        {"p3", "Bengkulu"},
        {"p4", "Riau"},
        {"image", false},
        {"comment", "Soal no 35"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Karung berasal dari daerah..."},
        {"answer", "Jambi"},
        {"p1", "Bangka Belitung"},
        {"p2", "Lampung"},
        {"p3", "Banten"},
        {"p4", "Jambi"},
        {"image", false},
        {"comment", "Soal no 36"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Paksian berasal dari daerah..."},
        {"answer", "Bangka Belitung"},
        {"p1", "Bangka Belitung"},
        {"p2", "Lampung"},
        {"p3", "Banten"},
        {"p4", "Jambi"},
        {"image", false},
        {"comment", "Soal no 37"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Tulang Bawang berasal dari daerah..."},
        {"answer", "Lampung"},
        {"p1", "Banten"},
        {"p2", "Lampung"},
        {"p3", "DKI Jakarta"},
        {"p4", "Jambi"},
        {"image", false},
        {"comment", "Soal no 38"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Pangsi berasal dari daerah..."},
        {"answer", "Banten"},
        {"p1", "Lampung"},
        {"p2", "Banten"},
        {"p3", "DKI Jakarta"},
        {"p4", "Jambi"},
        {"image", false},
        {"comment", "Soal no 39"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Kebaya Encim berasal dari daerah..."},
        {"answer", "DKI Jakarta"},
        {"p1", "Jawa Barat"},
        {"p2", "Daerah Istimewa Yogyakarta"},
        {"p3", "Jawa Tengah"},
        {"p4", "DKI Jakarta"},
        {"image", false},
        {"comment", "Soal no 40"}
    },new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Pesa’an berasal dari daerah..."},
        {"answer", "Jawa Timur"},
        {"p1", "Jawa Timur"},
        {"p2", "Jawa Tengah"},
        {"p3", "Jawa Barat"},
        {"p4", "DKI Jakarta"},
        {"image", false},
        {"comment", "Soal no 41"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Payas Agung berasal dari daerah..."},
        {"answer", "Bali"},
        {"p1", "Aceh"},
        {"p2", "Bali"},
        {"p3", "Jambi"},
        {"p4", "Riau"},
        {"image", false},
        {"comment", "Soal no 42"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Pegon berasal dari daerah..."},
        {"answer", "Nusa Tenggara Barat"},
        {"p1", "Papua"},
        {"p2", "Bali"},
        {"p3", "Nusa Tenggara Barat"},
        {"p4", "Aceh"},
        {"image", false},
        {"comment", "Soal no 43"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Amarasi berasal dari daerah..."},
        {"answer", "Nusa Tenggara Timur"},
        {"p1", "Papua"},
        {"p2", "Bali"},
        {"p3", "Nusa Tenggara Barat"},
        {"p4", "Nusa Tenggara Timur"},
        {"image", false},
        {"comment", "Soal no 44"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Billu dan Makuta berasal dari daerah..."},
        {"answer", "Gorontalo"},
        {"p1", "Gorontalo"},
        {"p2", "Papua"},
        {"p3", "Bali"},
        {"p4", "Aceh"},
        {"image", false},
        {"comment", "Soal no 45"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Ewer berasal dari daerah..."},
        {"answer", "Papua Barat"},
        {"p1", "Papua Selatan"},
        {"p2", "Papua Barat"},
        {"p3", "Nusa Tenggara Timur"},
        {"p4", "Nusa Tenggara Barat"},
        {"image", false},
        {"comment", "Soal no 46"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat yang berasal dari Papua, Papua Selatan, Papua Tengah adalah..."},
        {"answer", "Koteka"},
        {"p1", "Ewer"},
        {"p2", "Bodo"},
        {"p3", "Amarasi"},
        {"p4", "Koteka"},
        {"image", false},
        {"comment", "Soal no 47"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Pummi berasal dari daerah..."},
        {"answer", "Papua Selatan"},
        {"p1", "Papua Selatan"},
        {"p2", "Aceh"},
        {"p3", "Jambi"},
        {"p4", "Riau"},
        {"image", false},
        {"comment", "Soal no 48"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Ta’a dan sapei sapaq berasal dari daerah..."},
        {"answer", "Kalimantan Utara"},
        {"p1", "Kalimantan Timur"},
        {"p2", "Kalimantan Barat"},
        {"p3", "Kalimantan Selatan"},
        {"p4", "Kalimantan Utara"},
        {"image", false},
        {"comment", "Soal no 49"}
    },
    new Dictionary<string, dynamic>
    {
        {"quiz", "Baju adat Pattuqduq Towaine berasal dari daerah..."},
        {"answer", "Sulawesi Barat"},
        {"p1", "Sulawesi Barat"},
        {"p2", "Sulawesi Selatan"},
        {"p3", "Sulawesi Tengah"},
        {"p4", "Sulawesi Utara"},
        {"image", false},
        {"comment", "Soal no 50"}
    }
        };
    }
    public List<Dictionary<String, dynamic>> AlatMusik()
    {
        return new List<Dictionary<String, dynamic>>{
            new Dictionary<string, dynamic>
            {
                {"quiz", "Gong merupakan salah satu dari alat musik tradisional di Indonesia yang dimainkan dengan cara..."},
                {"answer", "Dipukul"},
                {"p1", "Dipetik"},
                {"p2", "Dipukul"},
                {"p3", "Digesek"},
                {"p4", "Digoyang"},
                {"image", false},
                {"comment", "Soal no 1"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Gambar diatas merupakan alat musik tradisional Talindo yang berasal dari daerah..."},
                {"answer", "Makassar"},
                {"p1", "Jawa Tengah"},
                {"p2", "Jawa Barat"},
                {"p3", "Lampung"},
                {"p4", "Makassar"},
                {"image", true},
                {"comment", "Soal no 2"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Nama alat musik tradisional pada gambar disamping adalah..."},
                {"answer", "Gamelan"},
                {"p1", "Angklung"},
                {"p2", "Calung"},
                {"p3", "Gendang"},
                {"p4", "Gamelan"},
                {"image", true},
                {"comment", "Soal no 3"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Salah satu alat musik tradisional yang berfungsi untuk mengharmoniskan atau menyelaraskan antara melodi dan ritme adalah..."},
                {"answer", "Bonang"},
                {"p1", "Kecapi"},
                {"p2", "Angklung"},
                {"p3", "Bonang"},
                {"p4", "Seruling"},
                {"image", false},
                {"comment", "Soal no 4"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Dibawah ini yang merupakan jenis alat musik tradisional dari Jawa Barat adalah..."},
                {"answer", "Calung"},
                {"p1", "Kecapi"},
                {"p2", "Gendang"},
                {"p3", "Calung"},
                {"p4", "Rebab"},
                {"image", false},
                {"comment", "Soal no 5"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berikut ini adalah alat musik tradisional yang berasal dari Sulawesi Selatan yaitu..."},
                {"answer", "Basing Bugis"},
                {"p1", "Kasapi"},
                {"p2", "Kecapi"},
                {"p3", "Basing Bugis"},
                {"p4", "Popandi"},
                {"image", false},
                {"comment", "Soal no 6"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Musik tradisional yang memiliki lirik masih kental dengan Islam dan menjadi bagian dari media menjalankan dakwah di Riau dinamakan sebagai..."},
                {"answer", "Gambus"},
                {"p1", "Gamelan"},
                {"p2", "Samrah"},
                {"p3", "Gambang Rancang"},
                {"p4", "Gambus"},
                {"image", false},
                {"comment", "Soal no 7"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Nama alat musik tradisional pada gambar diatas adalah..."},
                {"answer", "Gendang"},
                {"p1", "Gendang"},
                {"p2", "Kecapi"},
                {"p3", "Calung"},
                {"p4", "Gamelan"},
                {"image", true},
                {"comment", "Soal no 8"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Angklung merupakan alat musik tradisional yang berasal dari daerah..."},
                {"answer", "Jawa Barat"},
                {"p1", "Jambi"},
                {"p2", "Bengkulu"},
                {"p3", "Jawa Barat"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 9"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tifa merupakan alat musik tradisional yang berasal dari daerah..."},
                {"answer", "Papua"},
                {"p1", "Papua"},
                {"p2", "Jawa Barat"},
                {"p3", "Sulawesi Selatan"},
                {"p4", "Sulawesi Barat"},
                {"image", false},
                {"comment", "Soal no 10"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Sasando merupakan alat musik tradisional yang berasal dari daerah..."},
                {"answer", "NTT"},
                {"p1", "Jawa Barat"},
                {"p2", "Jawa Tengah"},
                {"p3", "NTT"},
                {"p4", "Papua"},
                {"image", false},
                {"comment", "Soal no 11"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Sasando dimainkan dengan cara..."},
                {"answer", "Dipetik"},
                {"p1", "Dipukul"},
                {"p2", "Dipetik"},
                {"p3", "Ditiup"},
                {"p4", "Digoyang"},
                {"image", false},
                {"comment", "Soal no 12"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Angklung dimainkan dengan cara..."},
                {"answer", "Digoyang"},
                {"p1", "Dipetik"},
                {"p2", "Digoyang"},
                {"p3", "Dipukul"},
                {"p4", "Ditiup"},
                {"image", false},
                {"comment", "Soal no 13"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Angklung alat musik tradisional yang terbuat dari..."},
                {"answer", "Belahan Bambu"},
                {"p1", "Plastik"},
                {"p2", "Besi"},
                {"p3", "Belahan Bambu"},
                {"p4", "Daun"},
                {"image", false},
                {"comment", "Soal no 14"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Tifa dimainkan dengan cara..."},
                {"answer", "Dipukul"},
                {"p1", "Dipukul"},
                {"p2", "Digoyang"},
                {"p3", "Dipetik"},
                {"p4", "Ditiup"},
                {"image", false},
                {"comment", "Soal no 15"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Dibawah ini yang termasuk alat musik tradisional yang berasal dari Sulawesi Utara adalah..."},
                {"answer", "Kolintang"},
                {"p1", "Gitar"},
                {"p2", "Kecapi"},
                {"p3", "Angklung"},
                {"p4", "Kolintang"},
                {"image", false},
                {"comment", "Soal no 16"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Panting merupakan alat musik khas Kalimantan Selatan yang terbuat dari..."},
                {"answer", "Kayu Rawali"},
                {"p1", "Kayu Rawali"},
                {"p2", "Bambu"},
                {"p3", "Besi"},
                {"p4", "Kertas"},
                {"image", false},
                {"comment", "Soal no 17"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Suling dimainkan dengan cara..."},
                {"answer", "Ditiup"},
                {"p1", "Ditiup"},
                {"p2", "Dipetik"},
                {"p3", "Digoyang"},
                {"p4", "Dipukul"},
                {"image", false},
                {"comment", "Soal no 18"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Keso-keso adalah alat musik khas Sulawesi Selatan yang dimainkan dengan cara..."},
                {"answer", "Menggesekkan alat khusus pada alat musik"},
                {"p1", "Menggesekkan alat khusus pada alat musik"},
                {"p2", "Dipetik dan dipukul"},
                {"p3", "Digoyang"},
                {"p4", "Ditiup dan dipetik"},
                {"image", false},
                {"comment", "Soal no 19"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Rebab merupakan alat musik gesek tradisional dari kayu yang sering digunakan untuk..."},
                {"answer", "Mengiringi wayang golek hingga tarian jaipong"},
                {"p1", "Mengiringi wayang golek hingga tarian jaipong"},
                {"p2", "Mengiringi upacara adat"},
                {"p3", "Pada musik keroncong hingga dangdut"},
                {"p4", "Penghias lagu"},
                {"image", false},
                {"comment", "Soal no 20"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Berikut ini alat tradisional dari Jawa Barat, kecuali..."},
                {"answer", "Anakbacing"},
                {"p1", "Angklung"},
                {"p2", "Kecapi"},
                {"p3", "Calung"},
                {"p4", "Anakbacing"},
                {"image", false},
                {"comment", "Soal no 21"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik berikut ini yang berasal dari daerah Nusa Tenggara Timur adalah..."},
                {"answer", "Sasando"},
                {"p1", "Bonang"},
                {"p2", "Gendang Beleq"},
                {"p3", "Popondi"},
                {"p4", "Sasando"},
                {"image", false},
                {"comment", "Soal no 22"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Sampe merupakan alat musik tradisional yang berasal dari daerah..."},
                {"answer", "Kalimantan Timur"},
                {"p1", "Jawa Barat"},
                {"p2", "Maluku"},
                {"p3", "Kalimantan Timur"},
                {"p4", "Aceh"},
                {"image", false},
                {"comment", "Soal no 23"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Sampe dimainkan dengan cara..."},
                {"answer", "Dipetik"},
                {"p1", "Dipetik"},
                {"p2", "Dipukul"},
                {"p3", "Digoyang"},
                {"p4", "Ditiup"},
                {"image", false},
                {"comment", "Soal no 24"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Doli-doli dimainkan dengan cara..."},
                {"answer", "Dipukul"},
                {"p1", "Ditiup"},
                {"p2", "Dipetik"},
                {"p3", "Digoyang"},
                {"p4", "Dipukul"},
                {"image", false},
                {"comment", "Soal no 25"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Kenong dimainkan dengan cara..."},
                {"answer", "Dipukul"},
                {"p1", "Dipukul"},
                {"p2", "Diketik"},
                {"p3", "Ditabuh"},
                {"p4", "Digoyang"},
                {"image", false},
                {"comment", "Soal no 26"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik tradisional yang berasal dari Jawa Barat, yaitu..."},
                {"answer", "Gamelan"},
                {"p1", "Gamelan"},
                {"p2", "Rebana"},
                {"p3", "Seruling"},
                {"p4", "Gamelan dan seruling"},
                {"image", false},
                {"comment", "Soal no 27"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik gendang beleq dimainkan dengan cara..."},
                {"answer", "Dipukul"},
                {"p1", "Dipukul"},
                {"p2", "Ditambah"},
                {"p3", "Ditiup"},
                {"p4", "Digoyang"},
                {"image", false},
                {"comment", "Soal no 28"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Ketiupung merupakan alat musik tradisional yang berasal dari Jawa Timur yang dimainkan dengan cara..."},
                {"answer", "Ditiup"},
                {"p1", "Ditup"},
                {"p2", "Dipetik"},
                {"p3", "Dipukul"},
                {"p4", "Ditabah"},
                {"image", false},
                {"comment", "Soal no 29"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Ganda berasal dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Jawa Timur"},
                {"p2", "Gorontalo"},
                {"p3", "Jawa Barat"},
                {"p4", "Sulawesi Selatan"},
                {"image", false},
                {"comment", "Soal no 30"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Talindo merupakan alat musik gesek tradisional dari daerah Makassar yang digunakan untuk..."},
                {"answer", "Mengiringi wayang golek hingga tari jaipong"},
                {"p1", "Mengiringi wayang golek hingga tari jaipong"},
                {"p2", "Mengiringi Upacara Adat"},
                {"p3", "Merayakan Pesta Panen"},
                {"p4", "Penghias Lagu"},
                {"image", false},
                {"comment", "Soal no 31"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Geso-geso berasal dari daerah..."},
                {"answer", "Toraja"},
                {"p1", "Sumatera Utara"},
                {"p2", "Jawa Timur"},
                {"p3", "Kalimantan Barat"},
                {"p4", "Toraja"},
                {"image", false},
                {"comment", "Soal no 32"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik berikut ini yang berasal dari daerah Sulawesi Tengah adalah..."},
                {"answer", "Lalove"},
                {"p1", "Lalove"},
                {"p2", "Talindo"},
                {"p3", "Geso-geso"},
                {"p4", "Angklung"},
                {"image", false},
                {"comment", "Soal no 33"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Lalove merupakan alat musik tradisional dari suku Kaili Sulawesi Tengah yang digunakan untuk..."},
                {"answer", "Ritual Penyembuhan"},
                {"p1", "Pada musik keroncong hingga dangdut"},
                {"p2", "Ritual Penyembuhan"},
                {"p3", "Merayakan pesta panen"},
                {"p4", "Penghias lagu"},
                {"image", false},
                {"comment", "Soal no 34"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Pupuik Tanduak berasal dari daerah..."},
                {"answer", "Sumatera Barat"},
                {"p1", "Riau"},
                {"p2", "Kalimantan Timur"},
                {"p3", "Sumatera Barat"},
                {"p4", "Toraja"},
                {"image", false},
                {"comment", "Soal no 35"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik tradisional Pupuik Tanduak yang berasal dari Sumatera Barat terbuat dari..."},
                {"answer", "Kulit Kerbau"},
                {"p1", "Kulit Sapi"},
                {"p2", "Tanduk Badak"},
                {"p3", "Kulit Kerbau"},
                {"p4", "Tanduk Kerbau"},
                {"image", false},
                {"comment", "Soal no 36"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Demung berasal dari daerah..."},
                {"answer", "Jawa Tengah"},
                {"p1", "Jawa Tengah"},
                {"p2", "Jawa Timur"},
                {"p3", "Jawa Barat"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 37"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Karinding berasal dari daerah..."},
                {"answer", "Jawa Barat"},
                {"p1", "Sumatera Utara"},
                {"p2", "Jawa Barat"},
                {"p3", "Sumatera Barat"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 38"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Karinding merupakan alat musik tradisional dari Jawa Barat yang digunakan untuk..."},
                {"answer", "Pengusir hama di sawah"},
                {"p1", "Pada musik keroncong hingga dangdut"},
                {"p2", "Ritual Penyembuhan"},
                {"p3", "Pengusir hama di sawah"},
                {"p4", "Penghias lagu"},
                {"image", false},
                {"comment", "Soal no 39"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Kuriding berasal dari daerah..."},
                {"answer", "Kalimantan Selatan"},
                {"p1", "Bali"},
                {"p2", "Toraja"},
                {"p3", "Papua"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 40"}
            },
             new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Siter berasal dari daerah..."},
                {"answer", "Jawa Tengah"},
                {"p1", "Jawa Tengah"},
                {"p2", "Sumatera Utara"},
                {"p3", "Jawa Barat"},
                {"p4", "Sulawesi Selatan"},
                {"image", false},
                {"comment", "Soal no 41"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Serunai berasal dari daerah..."},
                {"answer", "Sumatera Barat"},
                {"p1", "Bali"},
                {"p2", "Sumatera Barat"},
                {"p3", "Papua"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 42"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Serunai merupakan alat musik tradisional dari Sumatera Barat yang digunakan untuk..."},
                {"answer", "Tanam padi dan Pesta Panen"},
                {"p1", "Pada musik keroncong hingga dangdut"},
                {"p2", "Ritual Penyembuhan"},
                {"p3", "Tanam padi dan Pesta Panen"},
                {"p4", "Penghias lagu"},
                {"image", false},
                {"comment", "Soal no 43"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Aramba, Gonrang, dan Garantung berasal dari daerah..."},
                {"answer", "Sumatera Barat"},
                {"p1", "Sumatera Barat"},
                {"p2", "Jawa Tengah"},
                {"p3", "Papua"},
                {"p4", "Sumatera Utara"},
                {"image", false},
                {"comment", "Soal no 44"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Bende berasal dari daerah..."},
                {"answer", "Lampung"},
                {"p1", "Lampung"},
                {"p2", "Sumatera Barat"},
                {"p3", "Papua"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 45"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Santu berasal dari daerah..."},
                {"answer", "Sulawesi Tengah"},
                {"p1", "Bali"},
                {"p2", "Sulawesi Tengah"},
                {"p3", "Papua"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 46"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Panting berasal dari daerah..."},
                {"answer", "Sumatera Barat"},
                {"p1", "Bali"},
                {"p2", "Sumatera Barat"},
                {"p3", "Kalimantan Selatan"},
                {"p4", "Lampung"},
                {"image", false},
                {"comment", "Soal no 47"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Cengceng berasal dari daerah..."},
                {"answer", "Bali"},
                {"p1", "Lampung"},
                {"p2", "Sumatera Barat"},
                {"p3", "Papua"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 48"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Arumba berasal dari daerah..."},
                {"answer", "Kalimantan Selatan"},
                {"p1", "Jawa Barat"},
                {"p2", "Sumatera Barat"},
                {"p3", "Papua"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 49"}
            },
            new Dictionary<string, dynamic>
            {
                {"quiz", "Alat musik Reog berasal dari daerah..."},
                {"answer", "Jawa Tengah"},
                {"p1", "Bali"},
                {"p2", "Jawa Tengah"},
                {"p3", "Papua"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 50"}
            },
        };
    }
    public List<Dictionary<String, dynamic>> MakananTradisional()
    {
        return new List<Dictionary<String, dynamic>>   {
            new Dictionary<string, dynamic>{
                {"quiz", "Saat berkunjung ke Papua, saya menikmati makanan khas Papua yang terbuat dari tepung sagu dan diolah menggunakan kuah ikan. Makanan tradisional tersebut bernama..."},
                {"answer", "Papeda"},
                {"p1", "Kerak telor"},
                {"p2", "Jojorong"},
                {"p3", "Papeda"},
                {"p4", "Ketoprak"},
                {"image", false},
                {"comment", "Soal no 1"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Makanan ini sangat digemari oleh masyarakat Aceh karena berbahan dasar mie yang dimasak menggunakan bumbu rempah-rempah khas Aceh dan disajikan dengan sambal dan krupuk. Makanan khas Aceh tersebut adalah..."},
                {"answer", "Mie Aceh"},
                {"p1", "Mie kocok"},
                {"p2", "Mie Aceh"},
                {"p3", "Mie ayam"},
                {"p4", "Mie bakso"},
                {"image", false},
                {"comment", "Soal no 2"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Gudeg adalah salah satu makanan khas dari daerah..."},
                {"answer", "Yogyakarta"},
                {"p1", "Sumatra Barat"},
                {"p2", "Papua"},
                {"p3", "Sulawesi Selatan"},
                {"p4", "Yogyakarta"},
                {"image", false},
                {"comment", "Soal no 3"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Gambar dibawah ini yang merupakan makan khas yang berasal dari Sulawesi Selatan adalah ..."},
                {"answer", "Sup Konro"},
                {"p1", "Kepiting Soka"},
                {"p2", "Bubur Manado"},
                {"p3", "Palumara"},
                {"p4", "Sup Konro"},
                {"image", false},
                {"comment", "Soal no 4"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Daerah pembuatan makanan khas daerah rendang yaitu..."},
                {"answer", "Sumatra"},
                {"p1", "Kalimantan Timur"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Sumatra"},
                {"p4", "Sumatera Selatan"},
                {"image", false},
                {"comment", "Soal no 5"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Ikan tenggiri menjadi bahan baku makanan dari daerah Sumatera Selatan, makanan tradisional ini disebut..."},
                {"answer", "Mpek-mpek"},
                {"p1", "Surabi"},
                {"p2", "Pisang ijo"},
                {"p3", "Jalangkote"},
                {"p4", "Mpek-mpek"},
                {"image", false},
                {"comment", "Soal no 6"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Sop konro makanan tradisional dari provinsi ..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sulawesi Selatan"},
                {"p2", "Gorontalo"},
                {"p3", "Kalimantan Selatan"},
                {"p4", "Sulawesi Utara"},
                {"image", false},
                {"comment", "Soal no 7"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Beberapa daerah mempunyai makanan tradisional bernama soto. Soto Banjar berasal dari daerah..."},
                {"answer", "Kalimantan Selatan"},
                {"p1", "Sumatra Selatan"},
                {"p2", "Aceh"},
                {"p3", "Sulawesi Selatan"},
                {"p4", "Kalimantan Selatan"},
                {"image", false},
                {"comment", "Soal no 8"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Perhatikan gambar di bawah ini!\n\nGambar disamping merupakan makanan khas dari..."},
                {"answer", "Jawa Tengah"},
                {"p1", "Jambi"},
                {"p2", "Jawa Barat"},
                {"p3", "Jawa Tengah"},
                {"p4", "Yogyakarta"},
                {"image", true},
                {"comment", "Soal no 9"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Perhatikan gambar di bawah ini!\n\nNama kue tradisional pada gambar di samping adalah..."},
                {"answer", "Klepon / onde-onde"},
                {"p1", "Klepon / onde-onde"},
                {"p2", "Pisang ijo"},
                {"p3", "Pisang eppe"},
                {"p4", "Surabi"},
                {"image", true},
                {"comment", "Soal no 10"}
            },new Dictionary<string, dynamic>{
                {"quiz", "Empek-empek makanan khas dari daerah..."},
                {"answer", "Sumatra Selatan"},
                {"p1", "Lampung"},
                {"p2", "Sumatra Selatan"},
                {"p3", "Sumatra Barat"},
                {"p4", "Sulawesi Selatan"},
                {"image", false},
                {"comment", "Soal no 11"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Serabi makanan khas dari daerah..."},
                {"answer", "Jawa tengah"},
                {"p1", "Jawa tengah"},
                {"p2", "Jawa barat"},
                {"p3", "Jawa timur"},
                {"p4", "Yongyakarta"},
                {"image", false},
                {"comment", "Soal no 12"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Lapa-lapa adalah salah satu makanan khas dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sulawesi Selatan"},
                {"p2", "Sulawesi Barat"},
                {"p3", "Sulawesi Tenggara"},
                {"p4", "Gorontalo"},
                {"image", false},
                {"comment", "Soal no 13"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Berikut ini adalah makanan khas yang berasal dari daerah Sumatra Utara"},
                {"answer", "Bika Ambon"},
                {"p1", "Serabi"},
                {"p2", "Mie Aceh"},
                {"p3", "Empek-empek"},
                {"p4", "Bika Ambon"},
                {"image", false},
                {"comment", "Soal no 14"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Berikut ini adalah makanan khas yang berasal dari Bengkulu"},
                {"answer", "Pendap"},
                {"p1", "Gulai ikan"},
                {"p2", "Pendap"},
                {"p3", "Serabi"},
                {"p4", "Sop Konro"},
                {"image", false},
                {"comment", "Soal no 15"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Rujak cingur adalah makanan khas dari..."},
                {"answer", "Jawa Timur"},
                {"p1", "Jawa Barat"},
                {"p2", "Jawa Tengah"},
                {"p3", "Jawa Timur"},
                {"p4", "Yogyakarta"},
                {"image", false},
                {"comment", "Soal no 16"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Kerak telor adalah makanan khas dari daerah..."},
                {"answer", "DKI Jakarta"},
                {"p1", "DKI Jakarta"},
                {"p2", "Jawa Tengah"},
                {"p3", "Jawa Timur"},
                {"p4", "Yogyakarta"},
                {"image", false},
                {"comment", "Soal no 17"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Mie gomak adalah makanan khas suku..."},
                {"answer", "Batak"},
                {"p1", "Bugis"},
                {"p2", "Batak"},
                {"p3", "Mandar"},
                {"p4", "Fak fak"},
                {"image", false},
                {"comment", "Soal no 18"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Dibawah ini makanan khas Lampung yang tidak benar yaitu..."},
                {"answer", "bejak enjak"},
                {"p1", "gagodoh"},
                {"p2", "pisro"},
                {"p3", "bubur mengguh"},
                {"p4", "bejak enjak"},
                {"image", false},
                {"comment", "Soal no 19"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Pisang ijo adalah makanan khas dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sulawesi Selatan"},
                {"p2", "Maluku"},
                {"p3", "Papua"},
                {"p4", "Sumatera Barat"},
                {"image", false},
                {"comment", "Soal no 20"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Barongko adalah makanan khas dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "DKI Jakarta"},
                {"p2", "Papua"},
                {"p3", "Sumatera Barat"},
                {"p4", "Sulawesi Selatan"},
                {"image", false},
                {"comment", "Soal no 21"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Tahu petis adalah makanan khas dari daerah..."},
                {"answer", "Semarang"},
                {"p1", "Papua"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Semarang"},
                {"p4", "Aceh"},
                {"image", false},
                {"comment", "Soal no 22"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Nasi Bekepor adalah makanan khas dari daerah..."},
                {"answer", "Kalimantan Timur"},
                {"p1", "Aceh"},
                {"p2", "Kalimantan Timur"},
                {"p3", "Kalimtan Tengah"},
                {"p4", "Kalimtan Selatan"},
                {"image", false},
                {"comment", "Soal no 23"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Berikut ini yang termasuk makanan tradisional dari Gorontalo adalah..."},
                {"answer", "Ayam tuna"},
                {"p1", "Bika"},
                {"p2", "Ayam tuna"},
                {"p3", "Pisang ijo"},
                {"p4", "Sate Tuna Gorontalo"},
                {"image", false},
                {"comment", "Soal no 24"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Berikut ini yang termasuk makanan tradisional dari Nusa Tenggara Barat adalah..."},
                {"answer", "Ayam Taliwang"},
                {"p1", "Ayam Taliwang"},
                {"p2", "Soto Banjar"},
                {"p3", "Ikan bakar"},
                {"p4", "Nasi uduk"},
                {"image", false},
                {"comment", "Soal no 25"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Sokkol ubi adalah makanan khas dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sulawesi Barat"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Aceh"},
                {"p4", "Jawa Tengah"},
                {"image", false},
                {"comment", "Soal no 26"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Sebutkan asal daerah dan nama makanan pada gambar diatas..."},
                {"answer", "Sulawesi Selatan, Pijang iji"},
                {"p1", "Surabaya, Rawon"},
                {"p2", "Sulawesi Selatan, Pijang iji"},
                {"p3", "Aceh, Mie aceh"},
                {"p4", "Papua, Papeda"},
                {"image", true},
                {"comment", "Soal no 27"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Gambar diatas merupakan makanan khas dari daerah..."},
                {"answer", "Minangkabau"},
                {"p1", "Sulawesi Selatan"},
                {"p2", "Aceh"},
                {"p3", "DKI Jakarta"},
                {"p4", "Minangkabau"},
                {"image", true},
                {"comment", "Soal no 28"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Kepiting Soko adalah makanan khas dari daerah..."},
                {"answer", "Kalimantan Timur"},
                {"p1", "Kalimantan Utara"},
                {"p2", "Kalimantan Timur"},
                {"p3", "Aceh"},
                {"p4", "Minangkabau"},
                {"image", false},
                {"comment", "Soal no 29"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Ikan asar adalah makanan khas dari daerah..."},
                {"answer", "Aceh"},
                {"p1", "Maluku"},
                {"p2", "Maluku utara"},
                {"p3", "Jawa barat"},
                {"p4", "Aceh"},
                {"image", false},
                {"comment", "Soal no 30"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Bika Ambon makanan khas dari daerah..."},
                {"answer", "Sumatera Utara"},
                {"p1", "Sumatera Utara"},
                {"p2", "Aceh"},
                {"p3", "Jawa Tengah"},
                {"p4", "Jawa Barat"},
                {"image", false},
                {"comment", "Soal no 31"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Gulai makanan khas dari daerah..."},
                {"answer", "Riau"},
                {"p1", "Riau"},
                {"p2", "Jambi"},
                {"p3", "Aceh"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 32"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Tempoyak Ikan Patin khas dari Daerah..."},
                {"answer", "Jambi"},
                {"p1", "Jambi"},
                {"p2", "Sumatera Utara"},
                {"p3", "Sumatera Selatan"},
                {"p4", "Sumatera Barat"},
                {"image", false},
                {"comment", "Soal no 33"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Bubur Gunting khas dari daerah..."},
                {"answer", "Kalimantan Selatan"},
                {"p1", "Sumatera Barat"},
                {"p2", "Kalimantan Selatan"},
                {"p3", "Sulawesi Selatan"},
                {"p4", "DKI Jakarta"},
                {"image", false},
                {"comment", "Soal no 34"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Seruit khas dari daerah..."},
                {"answer", "Banten"},
                {"p1", "Lampung"},
                {"p2", "Banten"},
                {"p3", "Jambi"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 35"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Mie Bangka khas dari daerah..."},
                {"answer", "Bangka Belitung"},
                {"p1", "Bangka Belitung"},
                {"p2", "Kalimantan Utara"},
                {"p3", "Kalimantan Selatan"},
                {"p4", "Kalimantan Tengah"},
                {"image", false},
                {"comment", "Soal no 36"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Mie Lendir khas dari daerah..."},
                {"answer", "Papua"},
                {"p1", "Kepulauan Riau"},
                {"p2", "Papua"},
                {"p3", "Bali"},
                {"p4", "Jambi"},
                {"image", false},
                {"comment", "Soal no 37"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Karedok khas dari daerah..."},
                {"answer", "Jawa Barat"},
                {"p1", "Jawa Barat"},
                {"p2", "Jawa Timur"},
                {"p3", "Jawa Tengah"},
                {"p4", "DKI Jakarta"},
                {"image", false},
                {"comment", "Soal no 38"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Sop Semarang khas dari daerah..."},
                {"answer", "Jawa Tengah"},
                {"p1", "Jawa Tengah"},
                {"p2", "Jawa Barat"},
                {"p3", "Jawa Timur"},
                {"p4", "Yogyakarta"},
                {"image", false},
                {"comment", "Soal no 39"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Gohu Ika khas dari daerah..."},
                {"answer", "Maluku Utara"},
                {"p1", "Maluku Utara"},
                {"p2", "Banten"},
                {"p3", "Riau"},
                {"p4", "Bali"},
                {"image", false},
                {"comment", "Soal no 40"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Tahu Pong khas dari daerah..."},
                {"answer", "Jawa Tengah"},
                {"p1", "Jawa Tengah"},
                {"p2", "Nusa Tenggara Timur"},
                {"p3", "Bali"},
                {"p4", "Riau"},
                {"image", false},
                {"comment", "Soal no 41"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Kue Tat khas dari daerah..."},
                {"answer", "Yogyakarta"},
                {"p1", "Bengkulu"},
                {"p2", "DKI Jakarta"},
                {"p3", "Papua"},
                {"p4", "Yogyakarta"},
                {"image", false},
                {"comment", "Soal no 42"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Jagung Bose khas dari daerah..."},
                {"answer", "Nusa Tenggara Barat"},
                {"p1", "Nusa Tenggara Barat"},
                {"p2", "Maluku"},
                {"p3", "Papua"},
                {"p4", "Nusa Tenggara Timur"},
                {"image", false},
                {"comment", "Soal no 43"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Bubur Pedas khas dari daerah..."},
                {"answer", "Kalimantan Barat"},
                {"p1", "Kalimantan Barat"},
                {"p2", "Kalimantan Utara"},
                {"p3", "Kalimantan Selatan"},
                {"p4", "Kalimantan Timur"},
                {"image", false},
                {"comment", "Soal no 44"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Kalumpe khas dari daerah..."},
                {"answer", "Kalimantan Barat"},
                {"p1", "Kalimantan Tengah"},
                {"p2", "Kalimantan Barat"},
                {"p3", "Kalimantan Utara"},
                {"p4", "Kalimantan Timur"},
                {"image", false},
                {"comment", "Soal no 45"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Kuah Pilek dari daerah..."},
                {"answer", "Aceh"},
                {"p1", "Aceh"},
                {"p2", "Kalimantan Utara"},
                {"p3", "Kalimantan Barat"},
                {"p4", "Kalimantan Timur"},
                {"image", false},
                {"comment", "Soal no 46"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Gance Ruan khas dari daerah..."},
                {"answer", "Kalimantan Selatan"},
                {"p1", "Kalimantan Timur"},
                {"p2", "Kalimantan Selatan"},
                {"p3", "Kalimantan Utara"},
                {"p4", "Kalimantan Barat"},
                {"image", false},
                {"comment", "Soal no 47"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Dendeng Paru khas dari daerah..."},
                {"answer", "Sumatera Barat"},
                {"p1", "Sumatera Barat"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Sulawesi Barat"},
                {"p4", "Sulawesi Tengah"},
                {"image", false},
                {"comment", "Soal no 48"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Kue Sagu khas dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Papua Tengah"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Sulawesi Barat"},
                {"p4", "Sulawesi Utara"},
                {"image", false},
                {"comment", "Soal no 49"}
            },
            new Dictionary<string, dynamic>{
                {"quiz", "Bolu Paranggi khas dari daerah..."},
                {"answer", "Sulawesi Selatan"},
                {"p1", "Sulawesi Barat"},
                {"p2", "Sulawesi Selatan"},
                {"p3", "Sulawesi Tengah"},
                {"p4", "Sulawesi Utara"},
                {"image", false},
                {"comment", "Soal no 50"}
            },
        };
    }
}
