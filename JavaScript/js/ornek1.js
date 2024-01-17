/* var degisken1 = 56; 
let degisken2 = "";
const degisken3 = true; */


//yorum satırı

var degisken1 = 56; //tarayıcın genelinde erişilebilen bir değişken haline gelir
let degisken2 = ""; //tanımlandığı blok içerisinde erişilebilir
const degisken3 = 123; //sadece bir sefer değer ataması yapılarak, tekrar değer atamasını yapılmasını engeller

degisken1 = 34;
degisken2 = "Aykut BAŞTUĞ";
console.log(degisken2);

let toplam = degisken1 + degisken3;
console.log(toplam);

let adiSoyadi = "Aykut" + " " + "BAŞTUĞ";
console.log("adiSoyadi değişkeni=", adiSoyadi);

degisken1++;
console.log(degisken1);
degisken1 += 5;
console.log(degisken1);
degisken1 = (5 * 2) + 4;
console.log(degisken1);


let sayi = 123;
let ondalikliSayi = 123.54;
let metin = "asda";
let trueFalse = true;
let trueFalse2 = false;


let tarih = new Date("2024-01-12");

let renkler = ["kırmızı", "beyaz"];
let sayilar = [34, 52];
console.log("dizi:", renkler);

let kisi = { adi: "Aykut", soyadi: "Baştuğ", dogumTarihi: new Date("1986-08-29")};
let kisi2 = { adi: 'Aykut2\'un', soyadi: "Baştuğ2", dogumTarihi: new Date("1986-08-29")};

console.log("Kişi:", kisi);

let kisiler = [kisi, kisi2];
console.log(kisiler);
// kisiler.forEach(element => {
//     element.adi;
// });


let kisi3 = { adi: "Aykut'un", soyadi: "Baştuğ2\"sdf", dogumTarihi: new Date("1986-08-29")};
kisi3.yas = 19;

console.log("KişiYeni:", kisi3);