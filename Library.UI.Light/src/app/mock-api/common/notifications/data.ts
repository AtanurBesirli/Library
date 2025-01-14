/* eslint-disable */
import { DateTime } from 'luxon';

/* Get the current instant */
const now = DateTime.now();

export const notifications = [
    {
        id         : '493190c9-5b61-4912-afe5-78c21f1044d7',
        icon       : 'heroicons_mini:book-open',
        title      : 'Kitap İadesi',
        description: 'İade süresi yaklaşan kitap: "JavaScript: The Good Parts"',
        time       : now.minus({minute: 25}).toISO(), // 25 dakika önce
        read       : false,
    },
    {
        id         : '6e3e97e5-effc-4fb7-b730-52a151f0b641',
        image      : 'assets/images/avatars/male-04.jpg',
        description: '<strong>Leo Gill</strong> adlı kullanıcı "Web Development with Node.js" kitabını ödünç aldı.',
        time       : now.minus({minute: 50}).toISO(), // 50 dakika önce
        read       : true,
        link       : '/library/loan',
        useRouter  : true,
    },
    {
        id         : 'b91ccb58-b06c-413b-b389-87010e03a120',
        icon       : 'heroicons_mini:bell',
        title      : 'Yeni Kitap Eklendi',
        description: '"React in Action" adlı kitap kütüphaneye eklendi.',
        time       : now.minus({hour: 3}).toISO(), // 3 saat önce
        read       : false,
        link       : '/library/new-arrivals',
        useRouter  : true,
    },
    {
        id         : '541416c9-84a7-408a-8d74-27a43c38d797',
        icon       : 'heroicons_mini:calendar',
        title      : 'Rezervasyon Hatırlatma',
        description: 'Rezervasyon yaptığınız "Clean Code" kitabı 2 gün içinde hazır olacak.',
        time       : now.minus({hour: 5}).toISO(), // 5 saat önce
        read       : false,
        link       : '/library/reservations',
        useRouter  : true,
    },
    {
        id         : 'ef7b95a7-8e8b-4616-9619-130d9533add9',
        image      : 'assets/images/avatars/male-06.jpg',
        description: '<strong>Roger Murray</strong> kitabınızı zamanında iade etti.',
        time       : now.minus({hour: 7}).toISO(), // 7 saat önce
        read       : true,
        link       : '/library/returns',
        useRouter  : true,
    },
    {
        id         : 'eb8aa470-635e-461d-88e1-23d9ea2a5665',
        image      : 'assets/images/avatars/female-04.jpg',
        description: '<strong>Sophie Stone</strong> size "Python Crash Course" kitabını önerdi.',
        time       : now.minus({hour: 9}).toISO(), // 9 saat önce
        read       : true,
        link       : '/library/recommendations',
        useRouter  : true,
    },
    {
        id         : '8f8e1bf9-4661-4939-9e43-390957b60f42',
        icon       : 'heroicons_mini:calendar',
        title      : 'Rezervasyon Hatırlatma',
        description: 'Rezervasyon yaptığınız "Eloquent JavaScript" kitabı 3 gün içinde hazır olacak.',
        time       : now.minus({day: 3}).toISO(), // 3 gün önce
        read       : true,
        link       : '/library/reservations',
        useRouter  : true,
    },
    {
        id         : '30af917b-7a6a-45d1-822f-9e7ad7f8bf69',
        icon       : 'heroicons_mini:bell',
        title      : 'Yeni Kitap Eklendi',
        description: '"Node.js Design Patterns" adlı kitap kütüphaneye eklendi.',
        time       : now.minus({day: 4}).toISO(), // 4 gün önce
        read       : true,
        link       : '/library/new-arrivals',
        useRouter  : true,
    },
];
