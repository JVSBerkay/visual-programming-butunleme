-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 17 Oca 2023, 11:35:36
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `elektronik`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `laptoplar`
--

CREATE TABLE `laptoplar` (
  `UrunId` int(11) NOT NULL,
  `Marka` text NOT NULL,
  `STOK` int(11) NOT NULL,
  `UrunOzellikleri` text NOT NULL,
  `Isletimsistemi` text NOT NULL,
  `Ekranyenilemehizi` text NOT NULL,
  `GarantiTipi` text NOT NULL,
  `CihazAğırlığı` text NOT NULL,
  `EkranKartı` text NOT NULL,
  `EkranKartıHafızası` text NOT NULL,
  `EkranBoyutu` text NOT NULL,
  `Kapasite` text NOT NULL,
  `Dokunmatik Ekran` text NOT NULL,
  `ÇözünürlükStandartı` text NOT NULL,
  `Renk` text NOT NULL,
  `Bağlantılar` text NOT NULL,
  `Klavye` text NOT NULL,
  `İşlemcÇekirdekSayısı` int(11) NOT NULL,
  `SSDKapasitesi` text NOT NULL,
  `Çözünürlük` text NOT NULL,
  `Ram` text NOT NULL,
  `KullanımAmacı` text NOT NULL,
  `ŞarjlıKullanımSüresi` text NOT NULL,
  `EkranKartıTipi` text NOT NULL,
  `İşlemciModeli` text NOT NULL,
  `İşlemciNesli` text NOT NULL,
  `hdisk` text NOT NULL,
  `PanelTipi` text NOT NULL,
  `RamTipi` text NOT NULL,
  `OptikSürücüTipi` text NOT NULL,
  `EkranKartıBellekTipi` text NOT NULL,
  `MaksimumİşlemciHızı(GHz)` text NOT NULL,
  `Fiyat` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `laptoplar`
--

INSERT INTO `laptoplar` (`UrunId`, `Marka`, `STOK`, `UrunOzellikleri`, `Isletimsistemi`, `Ekranyenilemehizi`, `GarantiTipi`, `CihazAğırlığı`, `EkranKartı`, `EkranKartıHafızası`, `EkranBoyutu`, `Kapasite`, `Dokunmatik Ekran`, `ÇözünürlükStandartı`, `Renk`, `Bağlantılar`, `Klavye`, `İşlemcÇekirdekSayısı`, `SSDKapasitesi`, `Çözünürlük`, `Ram`, `KullanımAmacı`, `ŞarjlıKullanımSüresi`, `EkranKartıTipi`, `İşlemciModeli`, `İşlemciNesli`, `hdisk`, `PanelTipi`, `RamTipi`, `OptikSürücüTipi`, `EkranKartıBellekTipi`, `MaksimumİşlemciHızı(GHz)`, `Fiyat`) VALUES
(1, 'Monster Abra A7 V13.2.3', 30, 'Intel Core I5-12500h 16 Gb Ram 500gb Ssd 4gb Gtx1650 Freedos 15,6\" Fhd 144hz ABRA A5 V19.1.5', 'Free Dos', '144 Hz', 'Resmi Distribütör Garantili\r\n', '2 - 4 kg\r\n', 'Nvidia GeForce RTX 3050 Ti\r\n', '4 GB\r\n', '17,3 inç', 'Yok', 'Yok', 'Full HD (FHD)\r\n', 'Siyah', 'Bluetooth', 'Q Türkçe', 6, '500 GB\r\n', '1920 x 1080\r\n', '16 GB\r\n', 'Oyun', '3 Saat ve Altı\r\n', 'Harici', '11400H', '11. Nesil\r\n', 'Yok', 'IPS', 'DDR4', 'Yok', 'GDDR6', '4.5\r\n', 18.999),
(2, 'Apple Macbook Air 13', 25, ' M1 8gb 256gb Ssd Gümüş MGN93TU/A', 'Mac Os\r\n', 'Belirtilmemiş', 'Resmi Distribütör Garantili', 'Belirtilmemiş', 'M1 7 Çekirdekli\r\n', 'Paylaşımlı', '13 inç\r\n', 'Belirtilmemiş', 'Yok', 'Retina', 'Gri', 'HDMI', 'Q Türkçe\r\n', 8, '256 GB\r\n', '2560 x 1600\r\n', '8 GB\r\n', 'Ev - Okul', 'Belirtilmemiş', 'Belirtilmemiş', 'Apple M1\r\n', 'Belirtilmemiş', '256 GB\r\n', 'Belirtilmemiş', '', 'Belirtilmemiş', 'Belirtilmemiş', 'Belirtilmemiş', 18.975),
(3, 'LENOVO Ideapad ', 15, 'Intel Celeron N4020 4GB 128GB SSD 14\" HD DOS Dizüstü Bilgisayar 81VU006STX', 'Free Dos\r\n', 'Belirtilmemiş\r\n', 'Resmi Distribütör Garantili\r\n', '2 kg ve Altı\r\n', 'Intel UHD Graphics 600\r\n', 'Paylaşımlı', '14 inç\r\n', 'Belirtilmemiş\r\n', 'Yok\r\n', 'HD Ready (HD)\r\n', 'Gümüş', 'Belirtilmemiş', 'Q Türkçe', 2, '128 GB', '1366 x 768\r\n', '4 GB\r\n', 'Ev - Okul', 'Belirtilmemiş', 'DDR4', 'Intel Celeron', 'Belirtilmemiş', 'Yok', 'Belirtilmemiş', 'DDR4', 'Belirtilmemiş', 'Dahili', 'Belirtilmemiş', 4.837),
(4, 'Huawei Matebook D15', 222, 'AMD Ryzen 5 5500U 8GB 512GB SSD Gri Dizüstü Bilgisayar (Huawei Türkiye Garantili) MBOOKD15R5', 'Windows', '60 Hz\r\n', 'Huawei Türkiye Garantili\r\n', '2 kg ve Altı\r\n', 'AMD Radeon R5\r\n', '8 GB\r\n', '15,6 inç\r\n', '512 GB\r\n', 'Yok', 'Full HD (FHD)\r\n', 'Gümüş', 'USB', 'Q Türkçe\r\n', 6, '512 GB\r\n', '1920 x 1080\r\n', '8 GB\r\n', 'Ofis - İş\r\n', '6 Saat ve Üstü\r\n', 'Dahili', 'AMD Ryzen 5\r\n', 'Ryzen', '512 GB\r\n', 'belirtilmemis', 'DDR4', 'belirtilmemis', 'GDDR4\r\n', '2.4\r\n', 11.955);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `masaustubilgisayar`
--

CREATE TABLE `masaustubilgisayar` (
  `MARKA` text NOT NULL,
  `UrunId` int(11) NOT NULL,
  `Fiyat` double NOT NULL,
  `Ozellikler` text NOT NULL,
  `SSD Kapasitesi` text NOT NULL,
  `Ram` text NOT NULL,
  `Beden` text NOT NULL,
  `Ekran Kartı Bellek Tipi` text NOT NULL,
  `Bağlantılar` text NOT NULL,
  `İşlemci Nesli` text NOT NULL,
  `Optik Sürücü Tipi` text NOT NULL,
  `Ekran Boyutu` text NOT NULL,
  `Temel İşlemci Hızı (GHz)` text NOT NULL,
  `İşletim Sistemi` text NOT NULL,
  `İşlemci Frekansı` text NOT NULL,
  `HDMI` text NOT NULL,
  `Klavye` text NOT NULL,
  `İşlemci Modeli` text NOT NULL,
  `Kullanım Amacı` text NOT NULL,
  `Kapasite` text NOT NULL,
  `İşlemci Tipi` text NOT NULL,
  `Ekran Kartı` text NOT NULL,
  `Ekran Kartı Tipi` text NOT NULL,
  `Panel Tipi` text NOT NULL,
  `İşlemciÇekirdekSayi` int(11) NOT NULL,
  `ÇözünürlükStandartı` text NOT NULL,
  `Cihaz Ağırlığı` text NOT NULL,
  `Çözünürlük` text NOT NULL,
  `PowerSupply` text NOT NULL,
  `AzamiBellek` text NOT NULL,
  `Garanti Tipi` text NOT NULL,
  `EkranYenilemeHızı` text NOT NULL,
  `Garanti Süresi` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `masaustubilgisayar`
--

INSERT INTO `masaustubilgisayar` (`MARKA`, `UrunId`, `Fiyat`, `Ozellikler`, `SSD Kapasitesi`, `Ram`, `Beden`, `Ekran Kartı Bellek Tipi`, `Bağlantılar`, `İşlemci Nesli`, `Optik Sürücü Tipi`, `Ekran Boyutu`, `Temel İşlemci Hızı (GHz)`, `İşletim Sistemi`, `İşlemci Frekansı`, `HDMI`, `Klavye`, `İşlemci Modeli`, `Kullanım Amacı`, `Kapasite`, `İşlemci Tipi`, `Ekran Kartı`, `Ekran Kartı Tipi`, `Panel Tipi`, `İşlemciÇekirdekSayi`, `ÇözünürlükStandartı`, `Cihaz Ağırlığı`, `Çözünürlük`, `PowerSupply`, `AzamiBellek`, `Garanti Tipi`, `EkranYenilemeHızı`, `Garanti Süresi`) VALUES
('Zeiron Sx75 Plus ', 5, 10.831, 'I7-860 16gb 240gb Gt730 24\" Dual Curved Oyuncu Masaüstü Bilgisayar ZRN-SX75-PLS', '240 GB\r\n', '16 GB\r\n', 'Tek Ebat\r\n', 'DDR3', 'Wi-Fi\r\n', '1. Nesil\r\n', 'Yok', '24\" / 61 Ekran\r\n', '2.8', 'Free Dos\r\n', '3.00 GHz üstü\r\n', 'Var\r\n', 'RGB', '860', 'Oyun', '240', 'Intel Core i7\r\n', 'Nvidia GT730\r\n', 'Harici', 'IPS', 4, 'Full HD (FHD)\r\n', '2 - 4 kg\r\n', '1920 x 1080\r\n', '500 W ve üstü\r\n', '16 GB\r\n', 'Resmi Distribütör Garantili\r\n', 'Belirtilmemis', '2 Yıl\r\n'),
('Gamepage Fp80', 6, 7.899, 'I7-860 16gb 240gb+1tb Gt730 18.5\" Masaüstü Oyuncu Bilgisayar GMP-FP80', '240 GB', '16 GB\r\n', 'Tek Ebat\r\n', 'DDR3', 'Wi-Fi\r\n', '1. Nesil\r\n', 'Yok', '19\" / 48 Ekran\r\n', '2.8\r\n', 'Free Dos\r\n', '3.00 GHz üstü\r\n', 'Var', 'RGB', '860', 'Oyun', '1 TB\r\n', 'Intel Core i7\r\n', 'Nvıdıa GeForce GT 730\r\n', 'Harici', 'TN', 4, 'HD Ready (HD)\r\n', '2 - 4 kg\r\n', '1366 x 768\r\n', '350 - 500 W\r\n', '16 GB\r\n', 'Resmi Distribütör Garantili\r\n', '60 Hz\r\n', '2 Yıl\r\n');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sepet`
--

CREATE TABLE `sepet` (
  `UrunId` int(11) NOT NULL,
  `Marka` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `telefon`
--

CREATE TABLE `telefon` (
  `UrunId` int(11) NOT NULL,
  `Marka` text NOT NULL,
  `Fiyat` float NOT NULL,
  `Ozellikler` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `telefon`
--

INSERT INTO `telefon` (`UrunId`, `Marka`, `Fiyat`, `Ozellikler`) VALUES
(1, 'Huawei Mate Xs Duos 512 Gb\r\n', 31.799, 'Dahili Hafıza\r\n:\r\n512 GB\r\nCPU Aralık\r\n:\r\n2.5-3.2 GHz\r\nGaranti Tipi\r\n:\r\nHuawei Türkiye Garantili\r\nBağlantılar\r\n:\r\nWi-Fi\r\nPil Gücü (mAh)\r\n:\r\n4000 - 5000\r\nEkran Boyutu\r\n:\r\n6 inç ve üstü');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyeler`
--

CREATE TABLE `uyeler` (
  `uyeID` int(11) NOT NULL,
  `admin_mi` tinyint(3) UNSIGNED NOT NULL,
  `Kullanici` varchar(30) NOT NULL,
  `sifre` varchar(30) NOT NULL,
  `Eposta` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `uyeler`
--

INSERT INTO `uyeler` (`uyeID`, `admin_mi`, `Kullanici`, `sifre`, `Eposta`) VALUES
(1, 1, 'admin', 'root', 'ozcelikmehmetberkay@gmail.com'),
(2, 0, 'berkay', '12345', ''),
(3, 0, 'mberkay', '1234', 'J3erkay241@gmail.com'),
(4, 0, 'deneme', '1234', 'berkay@hotmail.com'),
(5, 0, '123', '1231', '31231@gmail.com'),
(7, 0, '23', '23', '123@hotmail.com'),
(8, 0, 'selcanaskaroglu', 'selcan', 'selcanaskaroglu@gmail.com');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `laptoplar`
--
ALTER TABLE `laptoplar`
  ADD PRIMARY KEY (`UrunId`);

--
-- Tablo için indeksler `masaustubilgisayar`
--
ALTER TABLE `masaustubilgisayar`
  ADD PRIMARY KEY (`UrunId`);

--
-- Tablo için indeksler `sepet`
--
ALTER TABLE `sepet`
  ADD KEY `UrunId` (`UrunId`);

--
-- Tablo için indeksler `telefon`
--
ALTER TABLE `telefon`
  ADD PRIMARY KEY (`UrunId`);

--
-- Tablo için indeksler `uyeler`
--
ALTER TABLE `uyeler`
  ADD PRIMARY KEY (`uyeID`),
  ADD UNIQUE KEY `Kullanici` (`Kullanici`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `laptoplar`
--
ALTER TABLE `laptoplar`
  MODIFY `UrunId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Tablo için AUTO_INCREMENT değeri `masaustubilgisayar`
--
ALTER TABLE `masaustubilgisayar`
  MODIFY `UrunId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Tablo için AUTO_INCREMENT değeri `telefon`
--
ALTER TABLE `telefon`
  MODIFY `UrunId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `uyeler`
--
ALTER TABLE `uyeler`
  MODIFY `uyeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `sepet`
--
ALTER TABLE `sepet`
  ADD CONSTRAINT `sepet_ibfk_1` FOREIGN KEY (`UrunId`) REFERENCES `laptoplar` (`UrunId`),
  ADD CONSTRAINT `sepet_ibfk_2` FOREIGN KEY (`UrunId`) REFERENCES `masaustubilgisayar` (`UrunId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
