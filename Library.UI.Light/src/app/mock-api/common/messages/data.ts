/* eslint-disable */
import { DateTime } from 'luxon';

/* Get the current instant */
const now = DateTime.now();

export const messages = [
    {
        id         : '832276cc-c5e9-4fcc-8e23-d38e2e267bc9',
        image      : 'assets/images/avatars/male-01.jpg',
        title      : 'Gary Peters',
        description: 'Kitap kulübü toplantısında bu konuyu konuşalım.',
        time       : now.minus({minutes: 25}).toISO(), // 25 dakika önce
        read       : false,
    },
    {
        id         : '608b4479-a3ac-4e26-8675-3609c52aca58',
        image      : 'assets/images/avatars/male-04.jpg',
        title      : 'Leo Gill (Üye #8817)',
        description: 'Yeni kitap önerilerimi kontrol edebilirsiniz.',
        time       : now.minus({minutes: 50}).toISO(), // 50 dakika önce
        read       : false,
    },
    {
        id         : '22148c0c-d788-4d49-9467-447677d11b76',
        image      : 'assets/images/avatars/female-01.jpg',
        title      : 'Sarah',
        description: 'Bugün ödünç aldığın kitabı iade etmeyi unutma!',
        time       : now.minus({hours: 3}).toISO(), // 3 saat önce
        read       : true,
        link       : '/library/returns',
        useRouter  : true,
    },
    {
        id         : '492e2917-760c-4921-aa5a-3201a857cd48',
        image      : 'assets/images/avatars/female-12.jpg',
        title      : 'Nancy Salazar &bull; Joy Yayınları',
        description: 'Yeni gelen kitapları Pazartesi günü düzenleyeceğim.',
        time       : now.minus({hours: 5}).toISO(), // 5 saat önce
        read       : true,
        link       : '/library/new-arrivals',
        useRouter  : true,
    },
    {
        id         : '214a46e5-cae7-4b18-9869-eabde7c7ea52',
        image      : 'assets/images/avatars/male-06.jpg',
        title      : 'Matthew Wood',
        description: 'Dostum, yeni kitabın kütüphaneye eklenmiş! Tebrikler, bunu kutlayalım!',
        time       : now.minus({hours: 7}).toISO(), // 7 saat önce
        read       : false,
        link       : '/library/new-arrivals',
        useRouter  : true,
    },
    {
        id         : '95930319-61cc-4c7e-9324-f1091865330c',
        image      : 'assets/images/avatars/female-04.jpg',
        title      : 'Elizabeth (Yeni Asistan)',
        description: 'Tüm kitapları katalogladım ama Geoffrey bir kitabı kayıp etti.',
        time       : now.minus({hours: 9}).toISO(), // 9 saat önce
        read       : false,
        link       : '/library/inventory',
        useRouter  : true,
    },
    {
        id         : '802935e9-9577-48bc-98d1-308a4872afd7',
        image      : 'assets/images/avatars/male-06.jpg',
        title      : 'William Bell',
        description: 'Bu kitabı gördün mü? Beraber okuyup tartışalım.',
        time       : now.minus({day: 1}).toISO(), // 1 gün önce
        read       : true,
        link       : 'https://www.google.com',
        useRouter  : false,
    },
    {
        id         : '059f3738-633b-48ea-ad83-19016ce24c62',
        image      : 'assets/images/avatars/female-09.jpg',
        title      : 'Cheryl Obrien - Kütüphane Yöneticisi',
        description: 'Neden hala sana gönderdiğim kitap listesine bakmadın!',
        time       : now.minus({day: 3}).toISO(), // 3 gün önce
        read       : false,
        link       : '/library/book-list',
        useRouter  : true,
    },
    {
        id         : '5c2bb44d-5ca7-42ff-ad7e-46ced9f49a24',
        image      : 'assets/images/avatars/female-15.jpg',
        title      : 'Joan Jones - Teknoloji',
        description: 'Dostum, Cheryl sürekli kitap listesi gönderiyor. Ne yapacağız?',
        time       : now.minus({day: 4}).toISO(), // 4 gün önce
        read       : true,
        link       : '/library/discussions',
        useRouter  : true,
    },
];

