# Kahve Menüsü Oluşturma Konsol Uygulaması

Bu uygulama, kullanıcıdan alınan girdilerle bir kahve menüsü oluşturur ve bu menüyü numaralandırılmış şekilde ekrana yazdırır. Kullanıcıdan beş farklı kahve ismi girmesi istenir ve ardından bu isimler bir liste olarak ekrana gösterilir.

## Program Yapısı

Bu program, `Program` sınıfında yer alan `Main` metodunda çalışmaktadır. Uygulama, kullanıcının tercih ettiği kahve isimlerini sırasıyla ister, bu isimleri bir listeye ekler ve sonunda listeyi numaralandırarak ekrana yazdırır.

### Program Akışı

1. Kullanıcıdan sırasıyla beş farklı kahve ismi girmesi istenir.
2. Girilen kahve isimleri bir listeye eklenir.
3. Liste ekrana numaralı şekilde yazdırılır.

### Örnek Çalışma

Program çalıştırıldığında konsolda şu adımlar görüntülenecektir:

```plaintext
Kahve menümüzü oluşturmak için tercihlerinize ihtiyacımız var!
Lütfen tercih ettiğiniz kahve için giriş yapınız.
Kahve1: Latte
Kahve2: Espresso
Kahve3: Mocha
Kahve4: Americano
Kahve5: Türk Kahvesi

Girilen Kahve İsimleri:
1 - Latte
2 - Espresso
3 - Mocha
4 - Americano
5 - Türk Kahvesi
