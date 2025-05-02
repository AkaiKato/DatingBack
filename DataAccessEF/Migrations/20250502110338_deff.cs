using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessEF.Migrations
{
    /// <inheritdoc />
    public partial class deff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("1317cb6d-c9ad-419c-9efe-e6837beb1f7c"), "", "Жизнь взаймы" },
                    { new Guid("1d39a158-f769-4bae-bacd-03fa80980053"), "", "Приключения Незнайки и его друзей" },
                    { new Guid("22e340d3-b0a0-4911-8c2c-1b9113585f6b"), "", "Сага о Форсайтах" },
                    { new Guid("24a90478-4a89-4f86-81a4-bc204c986fdd"), "", "Собачье сердце" },
                    { new Guid("33feb729-d71b-4344-bbf2-0662b7ec2875"), "", "Повелитель мух" },
                    { new Guid("3a78eb8a-733d-420c-b260-bf23c4e8a1cd"), "", "Мастер и Маргарита" },
                    { new Guid("43ea5dfd-a734-4d93-ae29-3c8aac2b2b28"), "", "А зори здесь тихие: В списках не значился (сборник)" },
                    { new Guid("451b062b-cc27-4884-a759-921264fea467"), "", "Робинзон Крузо" },
                    { new Guid("51525116-b210-42d9-877d-3466fabe3396"), "", "Сто лет одиночества" },
                    { new Guid("5747df06-8f43-4e8d-aa9c-03551d2879e8"), "", "Отверженные" },
                    { new Guid("67c01515-59ae-4940-9e9b-66160cd8d6d5"), "", "Над пропастью во ржи" },
                    { new Guid("6e77df4e-2f25-4a35-a3e9-8432fd7d1298"), "", "Двенадцать стульев. Полная версия романа" },
                    { new Guid("84af95da-53a0-48b5-b1bb-e51a0a8f58d3"), "", "На Западном фронте без перемен" },
                    { new Guid("90e4ee78-94d8-40a7-b964-80e46818ff3d"), "", "Унесенные ветром. Том 1" },
                    { new Guid("9d2773c8-20c6-44d2-be6b-28a53c0f1a80"), "", "Война и мир. Коллекционное иллюстрированное издание" },
                    { new Guid("a203e6d5-8d57-4a6e-af82-937fcf7e84fc"), "", "451 градус по Фаренгейту" },
                    { new Guid("a6a29e28-700e-46d1-a5d6-9ff627a53696"), "", "Маленький принц" },
                    { new Guid("a883a35c-823f-4be9-8f6c-eec7c6594a28"), "", "Тихий Дон" },
                    { new Guid("b22962bb-066d-43d6-a50d-daa1b9c258a3"), "", "Маленькие женщины" },
                    { new Guid("cadefb53-2965-4e99-a494-c1e7ceb2a8d2"), "", "Мертвые души" },
                    { new Guid("df31522f-ebb9-464e-bacd-0a81be1cbf96"), "", "Гордость и предубеждение" },
                    { new Guid("e35ca140-e232-404c-80b4-82b57df53aae"), "", "Портрет Дориана Грея" },
                    { new Guid("ea4b4c72-7b4c-42a6-81fe-1eab9b69b01e"), "", "Мартин Иден" },
                    { new Guid("fe9c4ad9-97e2-4336-826c-0c8d0ed815ef"), "", "Приключения Тома Сойера" }
                });

            migrationBuilder.InsertData(
                table: "DatingPurpose",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("787bb02a-5a44-44d3-bd23-2c0454660afb"), "Открыться свежим эмоциям и впечатлениям", "Новый опыт" },
                    { new Guid("c6b7b0cb-0502-4118-aff9-e842efbd168d"), "Обмениваться мемами и жизненными историями", "Дружеское общение" },
                    { new Guid("da7662d6-338f-424d-ad81-1008a948309b"), "Строить планы дольше чем на выходные", "Серьёзные отношения" },
                    { new Guid("e8818c4d-5fc1-44a8-9652-d253914bd164"), "Сохранять лёгкость и независимость", "Свободные отношения" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("0239f840-fca2-45b2-87b9-3e05182d2773"), "", "Медитации" },
                    { new Guid("091163fe-655c-4eaf-9ff1-66e67cec0244"), "", "Альпинизм" },
                    { new Guid("115b9d5b-adc8-4673-bd65-47a3fef83f86"), "", "Электроника" },
                    { new Guid("125a69be-89d6-491b-82a8-f7125936242b"), "", "Шопинг" },
                    { new Guid("279e79c1-5607-425a-8807-4cea9f439a75"), "", "Рестораны" },
                    { new Guid("2b675ce2-89d5-4e6f-9528-33426a473b8b"), "", "Сноуборд" },
                    { new Guid("2ed1f513-3077-4dc0-ab0f-014639dc5487"), "", "Встречи с друзьями" },
                    { new Guid("4581f1eb-6a07-4833-8230-6034220be47d"), "", "К-рор" },
                    { new Guid("45ff5540-cb5e-4e66-9835-22dbd6d529ab"), "", "Ролики" },
                    { new Guid("499f1df9-08af-4a84-ae87-df0d6d1b1982"), "", "Меломан" },
                    { new Guid("58c84f1e-5840-4385-af8d-48f3343a1d2b"), "", "Хип-хоп" },
                    { new Guid("5957578a-daa5-48cf-a6ae-d28cc1772f43"), "", "Компьютерные игры" },
                    { new Guid("5d7ec2a9-ce5a-45cc-920a-7028ce100a18"), "", "Поп-музыка" },
                    { new Guid("5f0d6f45-e15e-4b10-b169-69e6ea8acf58"), "", "Скейтборд" },
                    { new Guid("5ff1b847-2afa-4a09-b2f1-40df94ae073f"), "", "Музеи и галереи" },
                    { new Guid("63c40194-6c41-456a-a527-f1bc6100830d"), "", "Йога" },
                    { new Guid("6d34c20c-c3af-46d2-a2d0-b57fcf0e7d76"), "", "Мода и красота" },
                    { new Guid("739eb4ed-a1a9-4e47-b238-78908baeafc5"), "", "Прогулки" },
                    { new Guid("73b498be-6a0a-4bc5-96b7-b4207ab54255"), "", "Фанфики" },
                    { new Guid("7753e29e-319e-40b8-9df5-44d9e1e470fc"), "", "Караоке" },
                    { new Guid("7d2a1b97-710d-4c49-bccc-c1ab910c59e6"), "", "Лыжи" },
                    { new Guid("7dad975a-7eb4-44b7-af30-0aeca002a52b"), "", "Активный отдых" },
                    { new Guid("84710962-e326-4c4a-9e94-d32e64799859"), "", "Фестивали" },
                    { new Guid("857b9a32-339e-4eee-bf6d-c85e9fa73f25"), "", "изучение языков" },
                    { new Guid("8c9b0c45-e3cd-458a-bab7-50a4fba161b9"), "", "Велосипед" },
                    { new Guid("8d6e1e18-f773-449d-a3c1-ec8f3b04708f"), "", "Фитнес" },
                    { new Guid("932532ec-7849-4483-9e3c-fdc39acc810b"), "", "Концерты и шоу" },
                    { new Guid("9d9d78a8-5ec2-43af-a270-f286953ceea5"), "", "Путешествия" },
                    { new Guid("a4565009-b49a-4d9c-a919-dfc041ac09d3"), "", "Отдых на природе" },
                    { new Guid("a89802a9-7120-4c89-af18-9f62e1b373a4"), "", "Бег" },
                    { new Guid("a93d97ed-4db9-4d60-b9a3-edf1ea0e0b89"), "", "Коллекционирование" },
                    { new Guid("addf3d15-52ec-4506-ab93-667f492d6baf"), "", "Пилатес" },
                    { new Guid("b124ce10-45c6-4419-b3e1-8f6980ec54ea"), "", "Театры" },
                    { new Guid("b62187fb-a524-444e-8a90-f2b52469e43a"), "", "Верховая езда" },
                    { new Guid("c6590841-8ef2-4822-bb0e-a0033c34dc09"), "", "игры на приставке" },
                    { new Guid("ca0301ab-8910-4e80-bdf5-3e86c3173a6c"), "", "Техно" },
                    { new Guid("d1cba34a-b3ea-4a09-b121-42817b29ec67"), "", "Стриминги" },
                    { new Guid("d2f838a2-1a9c-48ed-a3f6-6a7d7517a349"), "", "Манга" },
                    { new Guid("d40a3d4f-b03b-431b-ae3f-85e2b5b8e4df"), "", "Астрология" },
                    { new Guid("e858ca76-f156-48be-94ab-c3310a8d3696"), "", "Классическая музыка" },
                    { new Guid("eec8b8b4-97fc-4e47-aa6f-03a559f9321f"), "", "Психология" },
                    { new Guid("f9aa8e3d-3ca9-46c0-9f90-fbfc2ad62001"), "", "Искусство" },
                    { new Guid("f9c7dc53-a488-4a4f-8c38-78cc61a3c88d"), "", "Тусовки и клубы" },
                    { new Guid("fe6ee647-c4c2-4228-b913-19c88a0a22e8"), "", "Мастер-классы" },
                    { new Guid("ff70fcca-8810-4491-8244-e467015f5ba0"), "", "IT и технологии" }
                });

            migrationBuilder.InsertData(
                table: "Musicans",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("002405aa-f188-42f7-9600-d2d2bada12e0"), "", "Enigma" },
                    { new Guid("0036dfcb-df47-4c9e-a687-3fd673915710"), "", "Justin Bieber" },
                    { new Guid("024bbb16-2782-426b-a63d-46a8bd993d96"), "", "Demi Lovato" },
                    { new Guid("0325881c-0189-4942-994e-a7b80671d2c1"), "", "Billy Fury" },
                    { new Guid("03416080-179d-47bc-9f8e-6baac22baafa"), "", "Eric Church" },
                    { new Guid("0359bcf4-e3d7-401b-9b71-23ca809caaea"), "", "Arrested Development" },
                    { new Guid("0432895e-1298-4d23-9a02-5219716b18cd"), "", "Hank Williams" },
                    { new Guid("07230977-1e94-4d27-b06e-8911e3f07588"), "", "Elton John" },
                    { new Guid("07522f27-072f-4230-a324-8cf7bbdf62d0"), "", "Counting Crows" },
                    { new Guid("07565826-804e-4541-a6eb-38dee747850a"), "", "John Fogerty" },
                    { new Guid("082f6f07-4bfd-4323-a1e3-fe3a4c3d0d06"), "", "The Brothers Johnson" },
                    { new Guid("08814c73-c779-4d02-b9bd-053a07a1bee8"), "", "Def Leppard" },
                    { new Guid("0954619e-6d92-4dc8-a9f7-e733e10d0017"), "", "Dire Straits" },
                    { new Guid("09fbcf99-9aec-4765-b320-f2f961b7d996"), "", "Coleman Hawkins" },
                    { new Guid("0be8dbeb-f6d3-47d0-9eea-17837ad3c770"), "", "Bob Marley" },
                    { new Guid("0c131a79-bc39-4544-85c5-30bbbcb9a8b7"), "", "Ben Howard" },
                    { new Guid("0c26f7c0-25c1-4fad-ab53-48a4eee7cccd"), "", "Apache Indian" },
                    { new Guid("0c5c8764-42e5-4f87-9feb-287542af01f8"), "", "Antonio Carlos Jobim" },
                    { new Guid("0ca6f322-edc6-456c-8347-8305ddf31e9d"), "", "Joe Jackson" },
                    { new Guid("0d9fc079-f9af-4e5c-82ab-2ee032b90eaf"), "", "Julie London" },
                    { new Guid("0da7ba94-cc12-42a3-9212-e200368592bd"), "", "Grand Funk Railroad" },
                    { new Guid("0e2316c9-c213-43a1-a8c8-b7baf5ca9525"), "", "George Benson" },
                    { new Guid("0f62239a-c721-49e5-bf39-e1cf2e2684db"), "", "Disclosure" },
                    { new Guid("1122f52b-5827-4be9-be51-ae5e07bcad62"), "", "Genesis" },
                    { new Guid("1316bf9f-5f1f-4ca8-b149-f7af2e6a6c09"), "", "Dean Martin" },
                    { new Guid("13742dbe-8929-481c-9603-28f0ae8e0f4b"), "", "Aswad" },
                    { new Guid("1396f7ad-e962-41c5-8a93-2588fdd6e0cc"), "", "Foxy Brown" },
                    { new Guid("163d0460-aa3d-44e3-958c-0907d4f73f3a"), "", "Belinda Carlisle" },
                    { new Guid("171f95a1-c24a-43dd-abdf-8c39ac3f3f11"), "", "Amy Winehouse" },
                    { new Guid("18969036-051f-41cd-9391-eeb9f841f49d"), "", "Cinderella" },
                    { new Guid("19963600-7707-4507-b128-0e48652cfdbc"), "", "Janet Jackson" },
                    { new Guid("19cfb925-2586-41c8-893d-5d46d4ea79d3"), "", "Aerosmith" },
                    { new Guid("1ae5541c-cf56-40ba-a1dd-374f523811ff"), "", "The Allman Brothers Band" },
                    { new Guid("1b3e2725-df4f-40bd-8b23-874d8eccc124"), "", "James Brown" },
                    { new Guid("1cf8dcf6-a210-4e5e-87d4-ff666d4a9759"), "", "Chuck Berry" },
                    { new Guid("1e74a6a8-5ee2-4443-8341-1b0dad94b48e"), "", "Black Sabbath" },
                    { new Guid("1ed77bad-3a39-45b6-82d6-5eb02330f93b"), "", "Bryan Ferry" },
                    { new Guid("206ff810-f1c3-47fb-b08b-277104960706"), "", "ABBA" },
                    { new Guid("2121798b-5fa3-4656-a3cf-cc7a12657300"), "", "Ashley Campbell" },
                    { new Guid("21aaee8e-0186-43d3-abb1-b5233659b867"), "", "Jane's Addiction" },
                    { new Guid("22b50803-a5e3-4c13-b2b1-648f8e34a0fb"), "", "Barry White" },
                    { new Guid("23c44bf6-8c31-4edd-8d5d-057cbc4487b6"), "", "Georgie Fame" },
                    { new Guid("24946588-58ba-41e2-870a-06ba2790b8b4"), "", "Desmond Dekker" },
                    { new Guid("24db90aa-d7f6-47bd-abf9-3dbfca8bc7ec"), "", "Cher" },
                    { new Guid("25b4edb4-4fa2-4091-944f-96136f97a0e5"), "", "The Doors" },
                    { new Guid("25d7fa2c-e1f2-4bd9-a4ec-3393d5e7402a"), "", "The Game" },
                    { new Guid("26c25291-2197-4852-9127-a64401e15739"), "", "Buddy Guy" },
                    { new Guid("293535e6-7b4b-411a-b96f-dc034a522af5"), "", "Billy Currington" },
                    { new Guid("294f39df-e5d6-4e2a-b6da-8ac85cc394a5"), "", "Alice Cooper" },
                    { new Guid("2a6d711f-25cc-43e3-ab9c-262d85ea401a"), "", "John Mayall" },
                    { new Guid("2ae7c30b-a3b8-48a6-a94a-c9389adb6160"), "", "Caravan" },
                    { new Guid("2de1df8a-dd7d-4d82-b4b1-17e4fabb8651"), "", "Boyz II Men" },
                    { new Guid("3047d352-1b0b-4c3d-b4c1-778e68ff00b1"), "", "The Beatles" },
                    { new Guid("305b9cc1-e988-4d91-816f-a9bda196c310"), "", "D'Angelo" },
                    { new Guid("30b1899f-fc42-4f7b-8dac-012e8fe8f538"), "", "Agnetha Faltskog" },
                    { new Guid("324d9846-eb70-4667-a9e6-a60269720336"), "", "Graham Parker" },
                    { new Guid("336c7d05-5b72-40c7-818c-55d6bfd59006"), "", "Dierks Bentley" },
                    { new Guid("346b3662-215e-4eb6-8f8b-3084cef2ec49"), "", "Big Country" },
                    { new Guid("35f10a8e-5b01-414f-89c5-9d065c1df054"), "", "Glen Campbell" },
                    { new Guid("3815daef-12fc-4979-a47d-688ec4489173"), "", "Frida Lyngstad" },
                    { new Guid("38647614-44c7-4696-a9ec-342ff6aa6e40"), "", "Jackson 5" },
                    { new Guid("3d326b75-e69a-4c98-9bbc-9db6d99648c2"), "", "Gene Vincent" },
                    { new Guid("3e0c47ac-83c4-473e-a320-3bb551437016"), "", "Andrew W.K." },
                    { new Guid("3f72188d-fac2-4558-b65e-467b1ad9a0aa"), "", "Culture Club" },
                    { new Guid("3fd8c27d-dfa6-48c7-af04-d3c1e17bf92a"), "", "Danny Wilson & Gary Clark" },
                    { new Guid("3fdcc4b7-0d28-4634-a2dc-6bba1bf11f4a"), "", "Debarge" },
                    { new Guid("41b46e08-9606-4975-ac23-650edb54bab4"), "", "Elliott Smith" },
                    { new Guid("4258ba42-52cd-4cbd-9380-81d8b41dbc83"), "", "Halsey" },
                    { new Guid("42eecf38-1d1d-4d9e-8cf7-4cd404680653"), "", "Count Basie" },
                    { new Guid("43a727c9-0394-4445-88a5-63dd7b1c9f43"), "", "Bon Jovi" },
                    { new Guid("43e305c5-54f4-4b98-92ca-b1a192d6aa65"), "", "Common" },
                    { new Guid("44032cf7-89d7-472f-9adc-fcef6cb74d16"), "", "Cutting Crew" },
                    { new Guid("44534903-42e7-4005-bbc6-ab7dc8cd943c"), "", "George Michael" },
                    { new Guid("44e8c490-d6ba-427b-aba1-19a1effba1ee"), "", "Gregory Isaacs" },
                    { new Guid("4554fe81-fa78-4363-8508-840d151d0c60"), "", "Barclay James Harvest" },
                    { new Guid("46b1c214-7a79-4140-a5e3-2f5000e7452c"), "", "Gary Moore" },
                    { new Guid("4aa02176-1918-4810-a862-d58f39f3d55c"), "", "James Blake" },
                    { new Guid("4cf77a5a-0c22-4b2f-b24e-db591e054fa9"), "", "Drake" },
                    { new Guid("4d2671f6-47c8-4022-b8db-80cea71f56f7"), "", "Guns N' Roses" },
                    { new Guid("4d48652c-a64f-4ff7-8d00-37479aace3dc"), "", "Fats Domino" },
                    { new Guid("50af08c8-973a-4d8f-8045-e10f9f0ae61f"), "", "Albert King" },
                    { new Guid("52c858d8-7135-489f-8b81-8d38071f5612"), "", "George Strait" },
                    { new Guid("544911ca-a31f-47ad-9436-0a8e52d7b452"), "", "The All-American Rejects" },
                    { new Guid("58d12481-f10e-4771-b508-5e3a2e4ab9e1"), "", "Jessie J" },
                    { new Guid("594ab263-a2d1-4c7f-8bbb-140efca29607"), "", "Alison Krauss" },
                    { new Guid("59c2ded7-da62-4d91-a27b-3ea3c9d67fd1"), "", "Climax Blues Band" },
                    { new Guid("5a21069a-b469-4147-97f2-892078e358be"), "", "Glass Animals" },
                    { new Guid("5a38e935-a0ad-4a18-b6b8-19bd06fdb043"), "", "Joan Armatrading" },
                    { new Guid("5ac5f14b-dfb9-48fc-b1a7-66ca068d7de5"), "", "Humble Pie" },
                    { new Guid("5b6fcfa4-a21c-4359-9120-09baf3e34c4b"), "", "Captain Beefheart" },
                    { new Guid("5bc1b0b7-b8a6-4007-be15-8d50ca847e11"), "", "Huey Lewis & The News" },
                    { new Guid("5bd0a7ff-ab50-4331-80c9-8370873ebe95"), "", "John Mellencamp" },
                    { new Guid("5cb1b369-64f3-4d55-ac16-1c19040473a4"), "", "Bob Seger" },
                    { new Guid("5ddc2a01-2d6a-4d1e-9bea-059d11eadaeb"), "", "The Go-Go's" },
                    { new Guid("5e6bbce2-ff23-4962-8d86-889ebafd7f83"), "", "James Morrison" },
                    { new Guid("5f5c3d3b-6b7b-4fe4-9c2f-caa817583f05"), "", "Dusty Springfield" },
                    { new Guid("603bd0e3-19b4-44c8-b8a5-a46d86ec82a7"), "", "Blondie" },
                    { new Guid("621fa85b-0077-452e-a2f8-1a0a84ee7f66"), "", "Elvis Costello" },
                    { new Guid("64957565-c533-41d2-bb52-6dae698560c4"), "", "Four Tops" },
                    { new Guid("655a829e-c9f0-44ed-82f7-142eddad6ac7"), "", "Gregory Porter" },
                    { new Guid("65fdb4b2-6bac-4c18-b836-1d00f5429f5b"), "", "DMX" },
                    { new Guid("672965ac-3af1-478b-b663-b547b4d12fdd"), "", "Blind Faith" },
                    { new Guid("6751607d-c05d-465f-927a-e828662d8883"), "", "Bonnie Raitt" },
                    { new Guid("69f0bc3c-8959-4bf4-bba4-111235cc2abe"), "", "Bill Evans" },
                    { new Guid("6a21cf1c-ba51-407d-8ad3-eb3c510f4a37"), "", "Imagine Dragons" },
                    { new Guid("6aa61323-e6cd-4fdb-8e19-2f8549042baa"), "", "John Lennon" },
                    { new Guid("6bb70037-7f1c-4e23-af5f-a8b7b16c58df"), "", "Billy Preston" },
                    { new Guid("6c1dbb82-88ab-45b3-9bbc-63ac497141b3"), "", "The Damned" },
                    { new Guid("6c2ab558-8b48-4af7-bfab-6a7d3e318eb9"), "", "Gentle Giant" },
                    { new Guid("6e126f3d-b46e-4357-8f1f-5f3f8fcdd41e"), "", "James Taylor" },
                    { new Guid("6e67ee93-85a0-4cbe-929b-610575c230a7"), "", "The Cranberries" },
                    { new Guid("6e8edc8e-700c-4cf7-8513-8c743098f136"), "", "Jeru the Damaja" },
                    { new Guid("6ea202bd-c5a3-4a58-a014-6db810006670"), "", "Jr. Walker & The All Stars" },
                    { new Guid("6eb4b479-60e1-41a9-9856-00ca5965bfa8"), "", "Faust" },
                    { new Guid("6ecc1eb2-eb4d-4efb-8ddb-e7a2f4c61a4a"), "", "The Band" },
                    { new Guid("6f72f5a9-8e9f-4767-b605-7a82bc7b0a3d"), "", "Florence + The Machine" },
                    { new Guid("6f8ee2bd-bfbf-440b-93a9-07c3a2061999"), "", "Eddie Cochran" },
                    { new Guid("71ba3136-a141-468e-8395-e3d57707671c"), "", "Heart" },
                    { new Guid("71bc8393-0e05-4c41-9a09-ce111663a7a1"), "", "Daniel Hope" },
                    { new Guid("726d5eb5-f0b0-4437-a364-80ec611c9e1d"), "", "Jonny Lang" },
                    { new Guid("73e4f0b0-1581-4532-8981-42e93699a4bb"), "", "Black Eyed Peas" },
                    { new Guid("746a7c5f-b34c-4730-8ad0-482d65062cc4"), "", "Bee Gees" },
                    { new Guid("74e1f334-7afe-4e66-b2ca-efd98402aae6"), "", "Thousand Horses" },
                    { new Guid("78ac06fb-3dc5-49bd-b47b-0605d8d91c26"), "", "Burning Spear" },
                    { new Guid("7976342a-dec2-4a08-8d34-c457002b319f"), "", "The Clash" },
                    { new Guid("79a45a2e-bb27-4600-8905-71d488f48788"), "", "Eric B. & Rakim" },
                    { new Guid("79ba7548-6ef0-4474-82da-a56e8376c800"), "", "Fairport Convention" },
                    { new Guid("7d2172dc-9211-455d-bd32-e42658695253"), "", "Carpenters" },
                    { new Guid("7d6660cf-8b6c-41c3-b74c-349ebcb187e3"), "", "Ginger Baker" },
                    { new Guid("7e46cb88-3999-4df2-a451-820fa726f986"), "", "George Harrison" },
                    { new Guid("7e5dd0d9-dc93-4638-a853-c0756539d481"), "", "Charlie Parker" },
                    { new Guid("7f182416-53c2-452d-819b-39a861d09af4"), "", "Creedence Clearwater Revival" },
                    { new Guid("7f383afe-c462-4aae-a8f7-4b241bbdd0d9"), "", "Andrea Bocelli" },
                    { new Guid("8079e388-247e-4d11-8099-f8a4a31face7"), "", "Black Uhuru" },
                    { new Guid("80bb1fd3-4116-4ac7-a876-926aa15d095e"), "", "Joe Cocker" },
                    { new Guid("81238e44-67ac-45de-9096-199e3c2a0436"), "", "Diana Krall" },
                    { new Guid("822446d6-a359-495a-b9f2-6fb9bb5f2700"), "", "Buddy Holly" },
                    { new Guid("82f79e8e-a65c-4520-a7b6-66d913c3c212"), "", "Diana Ross & The Supremes" },
                    { new Guid("831e6063-6b38-405f-a034-c184fd018fcf"), "", "Gwen Stefani" },
                    { new Guid("83373834-67fc-428f-b5ab-aeaa13008312"), "", "Joni Mitchell" },
                    { new Guid("8431ea03-211c-4edb-95a2-f8e7aa0e6e36"), "", "The Human League" },
                    { new Guid("8439ad05-c997-4aae-9566-084b3ae30b08"), "", "The Common Linnets" },
                    { new Guid("864e17c4-5838-43e7-813c-22f368a0a61c"), "", "Gong" },
                    { new Guid("866d45ed-eab7-4432-ae14-e530349b3a1d"), "", "Joss Stone" },
                    { new Guid("872d2e02-a99f-425f-912e-2f4760c36c3f"), "", "Canned Heat" },
                    { new Guid("8827b747-0558-4587-8f8a-e14e767a386d"), "", "Jack Bruce" },
                    { new Guid("89850ed1-ed16-47ee-b554-497495c5057c"), "", "Fleetwood Mac" },
                    { new Guid("899a76f3-031f-4bb4-9c27-6c65a41eeeb6"), "", "Dinah Washington" },
                    { new Guid("89f008b5-9ba4-43d3-a0d7-354bd54acbf3"), "", "Gene Krupa" },
                    { new Guid("8b194f2e-45bf-4049-93bb-d7efc503511a"), "", "Bjork" },
                    { new Guid("8b4c65bc-dad5-4302-bee7-d7402f1c2aa3"), "", "Emeli Sande" },
                    { new Guid("8b5d1b05-78bf-42a7-a302-283fe0f20836"), "", "Freddie Mercury" },
                    { new Guid("8c37de4f-806f-4405-bfd2-31124e23be29"), "", "Eagles Of Death Metal" },
                    { new Guid("8c6b4fea-d1ea-4255-810e-1c9eb20d0185"), "", "John Martyn" },
                    { new Guid("8d45d734-1211-4ea7-8f44-91da9e6dda0a"), "", "Etta James" },
                    { new Guid("908d41ca-3c11-4336-afeb-093bbe0a8b90"), "", "Jimmy Buffett" },
                    { new Guid("90d36efe-f278-4bf3-8464-6d088afe1239"), "", "The Cure" },
                    { new Guid("90e8865e-0c4b-4417-b17d-62d873675a01"), "", "Bruce Springsteen" },
                    { new Guid("912bf2fd-e940-4e78-a743-5cc59a7f231c"), "", "Heaven 17" },
                    { new Guid("9147865c-81d8-4d92-8d9a-9ca4cf63e238"), "", "Free" },
                    { new Guid("91bf60ee-33b1-43cf-81f8-a15ba55795d9"), "", "Commodores" },
                    { new Guid("93181aa6-8fc0-45d7-8397-16604f148487"), "", "Big Star" },
                    { new Guid("93592216-f704-471c-9324-f3d68de0a076"), "", "Elbow" },
                    { new Guid("94a9e74f-bc62-49f7-9d27-70017ac01e8b"), "", "Corinne Bailey Rae" },
                    { new Guid("974e122f-f3c1-4040-9c5d-3f364fe1ed3c"), "", "Astrud Gilberto" },
                    { new Guid("97c38df6-d093-4622-b79e-7e294e234e40"), "", "Hoyt Axton" },
                    { new Guid("98792b81-13af-47b2-9b54-41b3bf012b9b"), "", "George Thorogood" },
                    { new Guid("998779d5-e47b-439e-a12e-ce254cf80a28"), "", "Iron Maiden" },
                    { new Guid("9a5807ad-9f3c-4075-97d5-ff282a269d0a"), "", "Eminem" },
                    { new Guid("9b2ec67e-f151-469b-92ee-cb9342bff657"), "", "James" },
                    { new Guid("9d7fe7db-8998-406b-9247-3ee154bc1162"), "", "Atlanta Rhythm Section" },
                    { new Guid("a08e797e-9cc8-4623-aac2-a706d90c3271"), "", "Frank Zappa" },
                    { new Guid("a1a1f268-34bf-4092-9999-f1931d11e54d"), "", "Foo Fighters" },
                    { new Guid("a2acbbb6-ead1-4ad3-b4bd-75b00174acaa"), "", "The Flying Burrito Brothers" },
                    { new Guid("a347530b-e88f-4243-b817-10e06c0aee98"), "", "Joe Sample" },
                    { new Guid("a4ea2eb5-9173-46d3-a99c-60914016dc49"), "", "Billie Holiday" },
                    { new Guid("a5a04554-18ea-4b73-9ca1-45c9b38d9442"), "", "Eazy-E" },
                    { new Guid("a5cbcf33-1a95-48b2-9aa1-e5a33935d201"), "", "The Jam" },
                    { new Guid("a70cbacf-1a44-4e39-9b21-7706ac4d66c1"), "", "David Bowie" },
                    { new Guid("a741bf61-7184-41e3-ac37-2dcf86e2540f"), "", "Anthrax" },
                    { new Guid("a9ed42dc-4688-458e-8caa-449eadd3fbd7"), "", "EELS" },
                    { new Guid("ad63474f-5bb4-4807-9f27-fac65a07e6e3"), "", "Brian Eno" },
                    { new Guid("ada94d4e-693d-4335-85e5-e3069ec5f338"), "", "Chris Stapleton" },
                    { new Guid("ae2fd147-dee0-4e33-9c3b-d3ee453ceaf4"), "", "Johnny Cash" },
                    { new Guid("ae92f072-5c39-4ebf-bfba-2f6d5532aee9"), "", "Derek And The Dominos" },
                    { new Guid("aec99586-581a-4558-9088-d201b92d4871"), "", "Badfinger" },
                    { new Guid("afd24607-2cfb-4b83-94aa-91951ee73d07"), "", "Iggy Pop" },
                    { new Guid("b03916d0-a3c1-46b6-badf-426ba65a05e6"), "", "Chris Cornell" },
                    { new Guid("b040a950-43db-430b-bf78-72f9715025dc"), "", "Cream" },
                    { new Guid("b2219b83-fac5-42da-af6d-e43922edfdc0"), "", "Benny Andersson" },
                    { new Guid("b5d7ca8d-c5e5-4396-a476-a8345d29ba88"), "", "John Lee Hooker" },
                    { new Guid("b66598ec-bf69-44d0-8214-84b540468921"), "", "Dio" },
                    { new Guid("b7ea6d59-e94d-4ca9-9eec-41ad87c29c22"), "", "Jurassic 5" },
                    { new Guid("b9673929-d430-49a8-a7f6-06d2386c9914"), "", "Herbie Hancock" },
                    { new Guid("b9ed57fd-acd1-40aa-96e2-c4556da6a27e"), "", "Blink-182" },
                    { new Guid("bb2776c2-bab6-4362-9be8-4b66e9980294"), "", "Arcade Fire" },
                    { new Guid("bbd95bb5-c38f-4ca8-8280-14c34df94cb7"), "", "Johnny Gill" },
                    { new Guid("bff80dd8-a6a3-4369-9b96-b8e3ace6ccb4"), "", "Bo Diddley" },
                    { new Guid("c1cf82cb-4be8-4953-8fd2-256f783cac61"), "", "J.J. Cale" },
                    { new Guid("c4a233ae-cdbe-43e0-8f39-cf673e967be6"), "", "Howlin Wolf" },
                    { new Guid("c5bf8747-048d-4528-a109-64726c8052de"), "", "John Williams" },
                    { new Guid("c6233219-29f1-4ae9-b91a-b31656138f4d"), "", "Burt Bacharach" },
                    { new Guid("c730b084-95ef-4c54-a6dc-d5b5757e1b22"), "", "Jimmy Smith" },
                    { new Guid("c7da0565-9b74-4610-97aa-f083b4a9b496"), "", "Joan Baez" },
                    { new Guid("c80d7549-fc3c-4953-89e0-3e9d173023ca"), "", "Eagles" },
                    { new Guid("c85f722e-96db-4abc-a78b-2ced1dd3b8ff"), "", "Ice Cube" },
                    { new Guid("c919c495-717d-4f01-8759-905607ac295a"), "", "Alan Jackson" },
                    { new Guid("c91c199a-ca57-4754-9b4b-07317ae04b53"), "", "The Chemical Brothers" },
                    { new Guid("c930970c-5740-40ab-9cd8-f3fd15ef118a"), "", "Elvis Presley" },
                    { new Guid("c998e780-06d2-441d-a393-54663534c478"), "", "Dr Dre" },
                    { new Guid("cbc14f22-5bb1-471f-8334-40e6f90ea57b"), "", "Jimmy Ruffin" },
                    { new Guid("cf457336-1b04-4991-8fd4-8191b5b6b483"), "", "Jadakiss" },
                    { new Guid("d0c96f23-7dbc-434c-829e-16357d0cae2e"), "", "Eve" },
                    { new Guid("d29089ae-3664-4061-be0b-12760e3d787b"), "", "Booker T" },
                    { new Guid("d5971d4d-a58b-46ec-939c-f4c2abe6296a"), "", "Jimmy Eat World" },
                    { new Guid("d5ba46df-374e-4601-a9a8-bd9fa0819558"), "", "Brantley Gilbert" },
                    { new Guid("d60ddc88-2bda-4da7-92ec-afb4c41aac72"), "", "Crowded House" },
                    { new Guid("d674a0da-a8cb-4c23-8edb-59083c6c6e3a"), "", "Donna Summer" },
                    { new Guid("d7b1559e-de7b-4857-aecd-894ebcfeab50"), "", "Audioslave" },
                    { new Guid("d88a0fd4-6c33-425f-973b-b6d1f294be1d"), "", "Billie Eilish" },
                    { new Guid("dc11c906-698a-4476-9caf-02fe4cfc28af"), "", "Don Henley" },
                    { new Guid("dd54b1d6-d64b-40b0-b01b-b678a9e15f08"), "", "Beastie Boys" },
                    { new Guid("ddc952a1-221a-486b-805f-c21a48bca86c"), "", "Eric Clapton" },
                    { new Guid("de085a6c-d8ac-4e4f-bcde-26c9bfd950bb"), "", "ABC" },
                    { new Guid("de8aaa5a-0ae4-47da-ad19-db2edc1915fe"), "", "Diana Ross" },
                    { new Guid("df44071a-29cf-4fa8-b1b0-8c229ad2bbb8"), "", "Brenda Holloway" },
                    { new Guid("e03a0b7c-3d80-43b9-8eba-d617dd332de9"), "", "Japan & David Sylvian" },
                    { new Guid("e0d98857-aadb-47af-a690-15604afcd8c1"), "", "INXS" },
                    { new Guid("e2172ace-0bcc-478d-8f70-63be5ee7b1fa"), "", "James Bay" },
                    { new Guid("e2986e39-d18d-4748-8251-62ff443fafd1"), "", "Bob Dylan" },
                    { new Guid("e2c8a7c6-39f0-4aad-978b-12c7c87a3b2a"), "", "Carrie Underwood" },
                    { new Guid("e3390560-c133-42d5-925f-4e630a9276fd"), "", "The Cadillac Three" },
                    { new Guid("e3d5a51d-f6bd-4524-b3e3-e87e26127b77"), "", "Blue Cheer" },
                    { new Guid("e4092c73-7495-4715-bb20-29b729215edb"), "", "Andre Rieu" },
                    { new Guid("e43a1ef6-9d92-49f1-8bed-36eca7babb51"), "", "Extreme" },
                    { new Guid("e46bd880-83d6-4783-84ca-e41be0821c8c"), "", "Ghostface Killah" },
                    { new Guid("e5e8412a-3cf8-46bb-a22c-c715a899de21"), "", "Fergie" },
                    { new Guid("e6f87ae8-4453-4148-a82a-d865e73a27fe"), "", "The Beach Boys" },
                    { new Guid("e778c83b-5a34-4add-bd39-911c73b9e5f3"), "", "B.B. King" },
                    { new Guid("e8c0d36a-f0ec-40eb-9668-4b741c648ce8"), "", "Jack Johnson" },
                    { new Guid("e9700938-01a9-4748-a80c-3f5260a3bbd5"), "", "Frankie Goes To Hollywood" },
                    { new Guid("e999f475-17e6-456b-b228-e169860c1bdd"), "", "Jimmy Cliff" },
                    { new Guid("eab7cb6b-1b7b-4757-85da-e3fe89e1e104"), "", "Bryan Adams" },
                    { new Guid("eb1fcdca-c6b4-4e94-bb2b-eb450ab7cdac"), "", "Jay-Z" },
                    { new Guid("eb23ee67-abcb-49d6-9f6a-40efdfd7266e"), "", "Duke Ellington" },
                    { new Guid("ebd01060-30e2-48f6-abea-78817befc48f"), "", "Jimi Hendrix" },
                    { new Guid("ec432079-c39a-42b8-99c8-3b4ad2142976"), "", "Frank Sinatra" },
                    { new Guid("ec4b5f9c-cf23-463b-8f58-47ed3cca6ca7"), "", "Deep Purple" },
                    { new Guid("ecd61f45-6af8-4588-842f-38ba83d67a2b"), "", "Craig Armstrong" },
                    { new Guid("ecdb5b1b-3065-44f8-9106-6e729c339a07"), "", "The Isley Brothers" },
                    { new Guid("ed408421-2687-47b9-ae4a-9e8c30517858"), "", "Jacques Brel" },
                    { new Guid("ed456b9a-bd6d-4996-8b5a-6261609d5c07"), "", "Demis Roussos" },
                    { new Guid("ee3bb160-ec3f-4e55-87a7-1e7d01cad7fe"), "", "EPMD" },
                    { new Guid("ef411ceb-391a-491a-96a6-e85a053af4aa"), "", "Grace Jones" },
                    { new Guid("ef517706-edb9-42a1-8a94-281c36b9d34a"), "", "Ben Harper" },
                    { new Guid("ef7831a3-c910-47c0-88d1-2bf47b39ce76"), "", "Camel" },
                    { new Guid("f3a9c739-59bf-4705-a1c4-86a20bafeb39"), "", "Isaac Hayes" },
                    { new Guid("f4141f98-bf6b-455c-aed5-a8f30383cee5"), "", "Helmet" },
                    { new Guid("f6071b44-13bc-4bee-8605-c9d3e98f579b"), "", "Ella Fitzgerald" },
                    { new Guid("f67bc459-a7fb-4d14-9033-6745cd6fe432"), "", "Hoobastank" },
                    { new Guid("f6bee1a7-59a0-4a44-9813-2b271bb5719c"), "", "Joe Walsh / The James Gang" },
                    { new Guid("f70d43a8-f531-4ea8-ba0e-438998d5bac5"), "", "Ariana Grande" },
                    { new Guid("f81cd9c6-4a82-4c6b-9e7c-f9ef13425120"), "", "Evanescence" },
                    { new Guid("f822992b-0329-4e91-ae46-eb940a6b2f00"), "", "John Coltrane" },
                    { new Guid("f91f4cce-8ccf-4e26-9ec0-18072c7ef51b"), "", "It Bites" },
                    { new Guid("fac7ee0d-3c93-49b1-b45e-72d772b23da2"), "", "Cheap Trick" },
                    { new Guid("fc031048-1b9d-4273-84ff-e03b6f96d5ac"), "", "Beck" },
                    { new Guid("fe505e3f-b221-485d-a2f8-bdacc5bd46ba"), "", "Jeezy" },
                    { new Guid("fedf6626-1534-46a3-8cce-da336c109603"), "", "Cat Stevens" },
                    { new Guid("ff846b37-5a1e-4237-a488-b22240d8cbf1"), "", "Gang Starr" }
                });

            migrationBuilder.InsertData(
                table: "PersonalTags",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("0169c78a-7978-4bf9-ad73-bb8879964c4c"), "", "Всё сложно" },
                    { new Guid("029e6be6-9017-49e5-a3af-0028a98d789b"), "", "Свободен" },
                    { new Guid("18312087-d12f-4d2e-83f4-b0779ea06739"), "", "Нет детей" },
                    { new Guid("208ee550-3a61-44c3-ae94-d76f93a737e6"), "", "Курю за компанию" },
                    { new Guid("32cd7168-78eb-4f2d-b346-53759321e307"), "", "Нет и не планирую" },
                    { new Guid("387d78ae-cc2f-493d-a64f-b1c9efeb5e47"), "", "Курю" },
                    { new Guid("3e83526c-d4bb-46c1-bad9-37172471ea70"), "", "Не люблю спорт" },
                    { new Guid("41c9685d-576b-4a64-be73-abde07de3b60"), "", "Не пью" },
                    { new Guid("4e2d3b03-a726-4efd-b648-cb27ba05f2a7"), "", "Есть дети" },
                    { new Guid("4fe428f7-d3aa-4446-9a3a-fc3ae0695c4d"), "", "Вейп" },
                    { new Guid("50ce9183-328f-446c-97d9-4679591dc5f4"), "", "Пью" },
                    { new Guid("93a00a1e-d808-4070-80d9-2a7a681c4d7f"), "", "Не курю" },
                    { new Guid("97851fb9-bd0e-4535-aea1-a2dfaef57380"), "", "В отношениях" },
                    { new Guid("9d0e4990-01a1-4d99-851d-6f19e8b64825"), "", "Редко" },
                    { new Guid("9df44fe0-798d-417d-9fb2-341c81e05a0c"), "", "Держу форму" },
                    { new Guid("a94883fa-9c43-4220-8c2a-05b0957055c9"), "", "Нет детей, но хочу" },
                    { new Guid("b228f121-ddc0-47ea-88ca-f751a7e1d87b"), "", "Хожу пешком" },
                    { new Guid("cf9c3983-8099-4231-b009-8e8d097dc767"), "", "Живу спортом" },
                    { new Guid("eb8636b8-edba-4f88-8ac6-01dfb9e5cb5b"), "", "Бросаю курить" }
                });

            migrationBuilder.InsertData(
                table: "TVMedias",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("024724b5-9241-4162-8819-c1c02d2d424f"), "", "Джентльмены" },
                    { new Guid("073dcd58-ca49-47ea-a4d1-7da08ecc0bc5"), "", "Титаник" },
                    { new Guid("0a6727e8-68e2-4e69-a5f8-59d12181414d"), "", "Постучись в мою дверь" },
                    { new Guid("0d1ad3bf-857a-40e2-adb1-80438efadbf9"), "", "Игра престолов" },
                    { new Guid("11425436-c405-457b-aa7b-b1c00b33b0f1"), "", "Интерстеллар" },
                    { new Guid("15b1deca-bf5a-4cba-a0b5-72811f6a7dc2"), "", "Маша и Медведь" },
                    { new Guid("1b669786-7838-4d81-a9e4-9cf7996236e2"), "", "Пираты Карибского моря: Проклятие Черной жемчужины" },
                    { new Guid("1fdcd989-df9b-4fec-99c9-3d03b982842a"), "", "Папины дочки. Новые" },
                    { new Guid("21437ee7-d5e6-4e3a-8c97-5692e8fef517"), "", "По щучьему велению" },
                    { new Guid("244eb6da-5636-4e82-b9cd-744ab210c7aa"), "", "Батя" },
                    { new Guid("25c1b108-ebf3-4135-946f-2195327dd424"), "", "Анора" },
                    { new Guid("2f25c623-2b2c-49fa-b98e-5857c8e9d099"), "", "Операция <Ы> и другие приключения Шурика" },
                    { new Guid("35b899e5-04f8-453b-a136-28d299443212"), "", "Зеленая книга" },
                    { new Guid("37292637-29ed-43f4-b721-dfa65e26cb97"), "", "Побег из Шоушенка" },
                    { new Guid("45d8fd67-ce45-4dec-86ef-7b000661bf8c"), "", "Триггер" },
                    { new Guid("4b63807c-b403-4347-9793-639ea44257b8"), "", "Гнев человеческий" },
                    { new Guid("51ac6ca6-4e96-4aa0-8e94-f25867a2ca39"), "", "Холоп" },
                    { new Guid("52b4281f-4203-47ad-b292-61467fe195f8"), "", "Переводчик" },
                    { new Guid("544a6e91-232c-4334-939d-3ead889fc084"), "", "Начало" },
                    { new Guid("5a08582b-2d1a-4694-b16d-45fadae689c0"), "", "Король и Шут" },
                    { new Guid("5b4d5676-e486-47d5-a8f0-0115337b8ba5"), "", "Вышка" },
                    { new Guid("5c98a29f-dc78-4962-85eb-824bcdd2c67d"), "", "Пчеловод" },
                    { new Guid("5f100308-ed5d-483f-9240-87f149cf37b2"), "", "Брат" },
                    { new Guid("65bb8bb6-c8fd-4f78-a256-e996cd13f5fc"), "", "Форрест Гамп" },
                    { new Guid("678dbdc3-c084-4031-b218-bc63808efb2d"), "", "Остров проклятых" },
                    { new Guid("6896d070-649a-4a72-8b9c-05fdb01d7e91"), "", "Любовь и голуби" },
                    { new Guid("6bcab5a5-7005-4bd8-b075-2bc30865b516"), "", "Монастырь" },
                    { new Guid("6d317001-ca50-4a0a-b657-36c3792f4fc0"), "", "Иван Васильевич меняет профессию" },
                    { new Guid("818f0525-2323-4647-8ec1-61d8c44374b0"), "", "Один дома" },
                    { new Guid("8207c3f2-d983-4c79-a47f-5ae676e5cfcd"), "", "Слово пацана. Кровь на асфальте" },
                    { new Guid("82286095-7582-4d64-8cd2-63eb404a1e41"), "", "Телохранители" },
                    { new Guid("8a12aee1-c677-4a98-a7e7-923dfad0d5d1"), "", "погоди!" },
                    { new Guid("92614014-031f-4a9e-b8ff-b46273c62c44"), "", "Холоп 2" },
                    { new Guid("95dc98c0-ae99-4745-9d25-cdb4834ad64f"), "", "Джентльмены удачи" },
                    { new Guid("9df4a59c-bff7-4f1a-a994-1a22ad4e87ed"), "", "Волк с Уолл-стрит" },
                    { new Guid("a055c605-092b-4da6-be11-06cde482ba6b"), "", "Ну" },
                    { new Guid("a2803d14-bdc1-4b41-b965-f3bb9a91b60b"), "", "Мажор" },
                    { new Guid("a927560e-bbef-43ae-bcbf-1e3fe22a495f"), "", "Аватар" },
                    { new Guid("aa5c4783-d448-4847-b798-58b47bc59e15"), "", "Бойцовский клуб" },
                    { new Guid("ae016554-6c27-49f0-99bb-10158a8d6072"), "", "Беспринципные" },
                    { new Guid("b4749593-1a50-4e51-baed-4555528f1466"), "", "Рик и Морти" },
                    { new Guid("c206c38c-b1e6-4cc5-aaba-5d6e4107e13c"), "", "Зверополис" },
                    { new Guid("c27f232a-8725-4d9d-a88f-c902aee031d5"), "", "Брат 2" },
                    { new Guid("cae10fb6-449a-48c6-92c6-13157b7cd26a"), "", "Области тьмы" },
                    { new Guid("ce879ad7-dd8a-44db-b649-d2e8be01298e"), "", "Операция <Фортуна>: Искусство побеждать" },
                    { new Guid("d3fa4a75-3995-4cd5-8722-da495d5c63ce"), "", "Достать ножи" },
                    { new Guid("da0a0012-64c7-41ef-b2a3-0c335a264a89"), "", "Веном" },
                    { new Guid("da5df2bb-4d35-4f08-bd2d-beed64bab740"), "", "Зеленая миля" },
                    { new Guid("f0950729-e5b3-4366-a63b-2f4a5e29e7f6"), "", "Легенда" },
                    { new Guid("f3ad64e9-f8ef-4393-95af-96866706f8eb"), "", "Гарри Поттер и философский камень" },
                    { new Guid("fb58fad1-586a-467f-aa2a-b64bc5000fcc"), "", "1 + 1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1317cb6d-c9ad-419c-9efe-e6837beb1f7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d39a158-f769-4bae-bacd-03fa80980053"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22e340d3-b0a0-4911-8c2c-1b9113585f6b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24a90478-4a89-4f86-81a4-bc204c986fdd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("33feb729-d71b-4344-bbf2-0662b7ec2875"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3a78eb8a-733d-420c-b260-bf23c4e8a1cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("43ea5dfd-a734-4d93-ae29-3c8aac2b2b28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("451b062b-cc27-4884-a759-921264fea467"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("51525116-b210-42d9-877d-3466fabe3396"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5747df06-8f43-4e8d-aa9c-03551d2879e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67c01515-59ae-4940-9e9b-66160cd8d6d5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e77df4e-2f25-4a35-a3e9-8432fd7d1298"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84af95da-53a0-48b5-b1bb-e51a0a8f58d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("90e4ee78-94d8-40a7-b964-80e46818ff3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d2773c8-20c6-44d2-be6b-28a53c0f1a80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a203e6d5-8d57-4a6e-af82-937fcf7e84fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6a29e28-700e-46d1-a5d6-9ff627a53696"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a883a35c-823f-4be9-8f6c-eec7c6594a28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b22962bb-066d-43d6-a50d-daa1b9c258a3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cadefb53-2965-4e99-a494-c1e7ceb2a8d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df31522f-ebb9-464e-bacd-0a81be1cbf96"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e35ca140-e232-404c-80b4-82b57df53aae"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea4b4c72-7b4c-42a6-81fe-1eab9b69b01e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fe9c4ad9-97e2-4336-826c-0c8d0ed815ef"));

            migrationBuilder.DeleteData(
                table: "DatingPurpose",
                keyColumn: "Id",
                keyValue: new Guid("787bb02a-5a44-44d3-bd23-2c0454660afb"));

            migrationBuilder.DeleteData(
                table: "DatingPurpose",
                keyColumn: "Id",
                keyValue: new Guid("c6b7b0cb-0502-4118-aff9-e842efbd168d"));

            migrationBuilder.DeleteData(
                table: "DatingPurpose",
                keyColumn: "Id",
                keyValue: new Guid("da7662d6-338f-424d-ad81-1008a948309b"));

            migrationBuilder.DeleteData(
                table: "DatingPurpose",
                keyColumn: "Id",
                keyValue: new Guid("e8818c4d-5fc1-44a8-9652-d253914bd164"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("0239f840-fca2-45b2-87b9-3e05182d2773"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("091163fe-655c-4eaf-9ff1-66e67cec0244"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("115b9d5b-adc8-4673-bd65-47a3fef83f86"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("125a69be-89d6-491b-82a8-f7125936242b"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("279e79c1-5607-425a-8807-4cea9f439a75"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("2b675ce2-89d5-4e6f-9528-33426a473b8b"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("2ed1f513-3077-4dc0-ab0f-014639dc5487"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("4581f1eb-6a07-4833-8230-6034220be47d"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("45ff5540-cb5e-4e66-9835-22dbd6d529ab"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("499f1df9-08af-4a84-ae87-df0d6d1b1982"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("58c84f1e-5840-4385-af8d-48f3343a1d2b"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("5957578a-daa5-48cf-a6ae-d28cc1772f43"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("5d7ec2a9-ce5a-45cc-920a-7028ce100a18"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("5f0d6f45-e15e-4b10-b169-69e6ea8acf58"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b847-2afa-4a09-b2f1-40df94ae073f"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("63c40194-6c41-456a-a527-f1bc6100830d"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("6d34c20c-c3af-46d2-a2d0-b57fcf0e7d76"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("739eb4ed-a1a9-4e47-b238-78908baeafc5"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("73b498be-6a0a-4bc5-96b7-b4207ab54255"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("7753e29e-319e-40b8-9df5-44d9e1e470fc"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("7d2a1b97-710d-4c49-bccc-c1ab910c59e6"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("7dad975a-7eb4-44b7-af30-0aeca002a52b"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("84710962-e326-4c4a-9e94-d32e64799859"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("857b9a32-339e-4eee-bf6d-c85e9fa73f25"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("8c9b0c45-e3cd-458a-bab7-50a4fba161b9"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("8d6e1e18-f773-449d-a3c1-ec8f3b04708f"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("932532ec-7849-4483-9e3c-fdc39acc810b"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("9d9d78a8-5ec2-43af-a270-f286953ceea5"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("a4565009-b49a-4d9c-a919-dfc041ac09d3"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("a89802a9-7120-4c89-af18-9f62e1b373a4"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("a93d97ed-4db9-4d60-b9a3-edf1ea0e0b89"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("addf3d15-52ec-4506-ab93-667f492d6baf"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("b124ce10-45c6-4419-b3e1-8f6980ec54ea"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("b62187fb-a524-444e-8a90-f2b52469e43a"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("c6590841-8ef2-4822-bb0e-a0033c34dc09"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("ca0301ab-8910-4e80-bdf5-3e86c3173a6c"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("d1cba34a-b3ea-4a09-b121-42817b29ec67"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("d2f838a2-1a9c-48ed-a3f6-6a7d7517a349"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("d40a3d4f-b03b-431b-ae3f-85e2b5b8e4df"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("e858ca76-f156-48be-94ab-c3310a8d3696"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("eec8b8b4-97fc-4e47-aa6f-03a559f9321f"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("f9aa8e3d-3ca9-46c0-9f90-fbfc2ad62001"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("f9c7dc53-a488-4a4f-8c38-78cc61a3c88d"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("fe6ee647-c4c2-4228-b913-19c88a0a22e8"));

            migrationBuilder.DeleteData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: new Guid("ff70fcca-8810-4491-8244-e467015f5ba0"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("002405aa-f188-42f7-9600-d2d2bada12e0"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0036dfcb-df47-4c9e-a687-3fd673915710"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("024bbb16-2782-426b-a63d-46a8bd993d96"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0325881c-0189-4942-994e-a7b80671d2c1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("03416080-179d-47bc-9f8e-6baac22baafa"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0359bcf4-e3d7-401b-9b71-23ca809caaea"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0432895e-1298-4d23-9a02-5219716b18cd"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("07230977-1e94-4d27-b06e-8911e3f07588"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("07522f27-072f-4230-a324-8cf7bbdf62d0"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("07565826-804e-4541-a6eb-38dee747850a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("082f6f07-4bfd-4323-a1e3-fe3a4c3d0d06"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("08814c73-c779-4d02-b9bd-053a07a1bee8"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0954619e-6d92-4dc8-a9f7-e733e10d0017"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("09fbcf99-9aec-4765-b320-f2f961b7d996"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0be8dbeb-f6d3-47d0-9eea-17837ad3c770"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0c131a79-bc39-4544-85c5-30bbbcb9a8b7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0c26f7c0-25c1-4fad-ab53-48a4eee7cccd"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0c5c8764-42e5-4f87-9feb-287542af01f8"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0ca6f322-edc6-456c-8347-8305ddf31e9d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0d9fc079-f9af-4e5c-82ab-2ee032b90eaf"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0da7ba94-cc12-42a3-9212-e200368592bd"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0e2316c9-c213-43a1-a8c8-b7baf5ca9525"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("0f62239a-c721-49e5-bf39-e1cf2e2684db"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1122f52b-5827-4be9-be51-ae5e07bcad62"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1316bf9f-5f1f-4ca8-b149-f7af2e6a6c09"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("13742dbe-8929-481c-9603-28f0ae8e0f4b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1396f7ad-e962-41c5-8a93-2588fdd6e0cc"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("163d0460-aa3d-44e3-958c-0907d4f73f3a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("171f95a1-c24a-43dd-abdf-8c39ac3f3f11"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("18969036-051f-41cd-9391-eeb9f841f49d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("19963600-7707-4507-b128-0e48652cfdbc"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("19cfb925-2586-41c8-893d-5d46d4ea79d3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1ae5541c-cf56-40ba-a1dd-374f523811ff"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1b3e2725-df4f-40bd-8b23-874d8eccc124"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1cf8dcf6-a210-4e5e-87d4-ff666d4a9759"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1e74a6a8-5ee2-4443-8341-1b0dad94b48e"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("1ed77bad-3a39-45b6-82d6-5eb02330f93b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("206ff810-f1c3-47fb-b08b-277104960706"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("2121798b-5fa3-4656-a3cf-cc7a12657300"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("21aaee8e-0186-43d3-abb1-b5233659b867"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("22b50803-a5e3-4c13-b2b1-648f8e34a0fb"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("23c44bf6-8c31-4edd-8d5d-057cbc4487b6"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("24946588-58ba-41e2-870a-06ba2790b8b4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("24db90aa-d7f6-47bd-abf9-3dbfca8bc7ec"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("25b4edb4-4fa2-4091-944f-96136f97a0e5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("25d7fa2c-e1f2-4bd9-a4ec-3393d5e7402a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("26c25291-2197-4852-9127-a64401e15739"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("293535e6-7b4b-411a-b96f-dc034a522af5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("294f39df-e5d6-4e2a-b6da-8ac85cc394a5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("2a6d711f-25cc-43e3-ab9c-262d85ea401a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("2ae7c30b-a3b8-48a6-a94a-c9389adb6160"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("2de1df8a-dd7d-4d82-b4b1-17e4fabb8651"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3047d352-1b0b-4c3d-b4c1-778e68ff00b1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("305b9cc1-e988-4d91-816f-a9bda196c310"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("30b1899f-fc42-4f7b-8dac-012e8fe8f538"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("324d9846-eb70-4667-a9e6-a60269720336"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("336c7d05-5b72-40c7-818c-55d6bfd59006"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("346b3662-215e-4eb6-8f8b-3084cef2ec49"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("35f10a8e-5b01-414f-89c5-9d065c1df054"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3815daef-12fc-4979-a47d-688ec4489173"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("38647614-44c7-4696-a9ec-342ff6aa6e40"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3d326b75-e69a-4c98-9bbc-9db6d99648c2"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3e0c47ac-83c4-473e-a320-3bb551437016"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3f72188d-fac2-4558-b65e-467b1ad9a0aa"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3fd8c27d-dfa6-48c7-af04-d3c1e17bf92a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("3fdcc4b7-0d28-4634-a2dc-6bba1bf11f4a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("41b46e08-9606-4975-ac23-650edb54bab4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("4258ba42-52cd-4cbd-9380-81d8b41dbc83"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("42eecf38-1d1d-4d9e-8cf7-4cd404680653"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("43a727c9-0394-4445-88a5-63dd7b1c9f43"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("43e305c5-54f4-4b98-92ca-b1a192d6aa65"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("44032cf7-89d7-472f-9adc-fcef6cb74d16"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("44534903-42e7-4005-bbc6-ab7dc8cd943c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("44e8c490-d6ba-427b-aba1-19a1effba1ee"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("4554fe81-fa78-4363-8508-840d151d0c60"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("46b1c214-7a79-4140-a5e3-2f5000e7452c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("4aa02176-1918-4810-a862-d58f39f3d55c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("4cf77a5a-0c22-4b2f-b24e-db591e054fa9"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("4d2671f6-47c8-4022-b8db-80cea71f56f7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("4d48652c-a64f-4ff7-8d00-37479aace3dc"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("50af08c8-973a-4d8f-8045-e10f9f0ae61f"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("52c858d8-7135-489f-8b81-8d38071f5612"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("544911ca-a31f-47ad-9436-0a8e52d7b452"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("58d12481-f10e-4771-b508-5e3a2e4ab9e1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("594ab263-a2d1-4c7f-8bbb-140efca29607"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("59c2ded7-da62-4d91-a27b-3ea3c9d67fd1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5a21069a-b469-4147-97f2-892078e358be"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5a38e935-a0ad-4a18-b6b8-19bd06fdb043"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5ac5f14b-dfb9-48fc-b1a7-66ca068d7de5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5b6fcfa4-a21c-4359-9120-09baf3e34c4b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5bc1b0b7-b8a6-4007-be15-8d50ca847e11"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5bd0a7ff-ab50-4331-80c9-8370873ebe95"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5cb1b369-64f3-4d55-ac16-1c19040473a4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5ddc2a01-2d6a-4d1e-9bea-059d11eadaeb"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5e6bbce2-ff23-4962-8d86-889ebafd7f83"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("5f5c3d3b-6b7b-4fe4-9c2f-caa817583f05"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("603bd0e3-19b4-44c8-b8a5-a46d86ec82a7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("621fa85b-0077-452e-a2f8-1a0a84ee7f66"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("64957565-c533-41d2-bb52-6dae698560c4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("655a829e-c9f0-44ed-82f7-142eddad6ac7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("65fdb4b2-6bac-4c18-b836-1d00f5429f5b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("672965ac-3af1-478b-b663-b547b4d12fdd"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6751607d-c05d-465f-927a-e828662d8883"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("69f0bc3c-8959-4bf4-bba4-111235cc2abe"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6a21cf1c-ba51-407d-8ad3-eb3c510f4a37"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6aa61323-e6cd-4fdb-8e19-2f8549042baa"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6bb70037-7f1c-4e23-af5f-a8b7b16c58df"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6c1dbb82-88ab-45b3-9bbc-63ac497141b3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6c2ab558-8b48-4af7-bfab-6a7d3e318eb9"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6e126f3d-b46e-4357-8f1f-5f3f8fcdd41e"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6e67ee93-85a0-4cbe-929b-610575c230a7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6e8edc8e-700c-4cf7-8513-8c743098f136"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6ea202bd-c5a3-4a58-a014-6db810006670"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6eb4b479-60e1-41a9-9856-00ca5965bfa8"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6ecc1eb2-eb4d-4efb-8ddb-e7a2f4c61a4a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6f72f5a9-8e9f-4767-b605-7a82bc7b0a3d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("6f8ee2bd-bfbf-440b-93a9-07c3a2061999"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("71ba3136-a141-468e-8395-e3d57707671c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("71bc8393-0e05-4c41-9a09-ce111663a7a1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("726d5eb5-f0b0-4437-a364-80ec611c9e1d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("73e4f0b0-1581-4532-8981-42e93699a4bb"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("746a7c5f-b34c-4730-8ad0-482d65062cc4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("74e1f334-7afe-4e66-b2ca-efd98402aae6"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("78ac06fb-3dc5-49bd-b47b-0605d8d91c26"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7976342a-dec2-4a08-8d34-c457002b319f"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("79a45a2e-bb27-4600-8905-71d488f48788"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("79ba7548-6ef0-4474-82da-a56e8376c800"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7d2172dc-9211-455d-bd32-e42658695253"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7d6660cf-8b6c-41c3-b74c-349ebcb187e3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7e46cb88-3999-4df2-a451-820fa726f986"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7e5dd0d9-dc93-4638-a853-c0756539d481"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7f182416-53c2-452d-819b-39a861d09af4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("7f383afe-c462-4aae-a8f7-4b241bbdd0d9"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8079e388-247e-4d11-8099-f8a4a31face7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("80bb1fd3-4116-4ac7-a876-926aa15d095e"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("81238e44-67ac-45de-9096-199e3c2a0436"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("822446d6-a359-495a-b9f2-6fb9bb5f2700"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("82f79e8e-a65c-4520-a7b6-66d913c3c212"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("831e6063-6b38-405f-a034-c184fd018fcf"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("83373834-67fc-428f-b5ab-aeaa13008312"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8431ea03-211c-4edb-95a2-f8e7aa0e6e36"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8439ad05-c997-4aae-9566-084b3ae30b08"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("864e17c4-5838-43e7-813c-22f368a0a61c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("866d45ed-eab7-4432-ae14-e530349b3a1d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("872d2e02-a99f-425f-912e-2f4760c36c3f"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8827b747-0558-4587-8f8a-e14e767a386d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("89850ed1-ed16-47ee-b554-497495c5057c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("899a76f3-031f-4bb4-9c27-6c65a41eeeb6"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("89f008b5-9ba4-43d3-a0d7-354bd54acbf3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8b194f2e-45bf-4049-93bb-d7efc503511a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8b4c65bc-dad5-4302-bee7-d7402f1c2aa3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8b5d1b05-78bf-42a7-a302-283fe0f20836"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8c37de4f-806f-4405-bfd2-31124e23be29"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8c6b4fea-d1ea-4255-810e-1c9eb20d0185"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("8d45d734-1211-4ea7-8f44-91da9e6dda0a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("908d41ca-3c11-4336-afeb-093bbe0a8b90"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("90d36efe-f278-4bf3-8464-6d088afe1239"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("90e8865e-0c4b-4417-b17d-62d873675a01"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("912bf2fd-e940-4e78-a743-5cc59a7f231c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("9147865c-81d8-4d92-8d9a-9ca4cf63e238"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("91bf60ee-33b1-43cf-81f8-a15ba55795d9"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("93181aa6-8fc0-45d7-8397-16604f148487"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("93592216-f704-471c-9324-f3d68de0a076"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("94a9e74f-bc62-49f7-9d27-70017ac01e8b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("974e122f-f3c1-4040-9c5d-3f364fe1ed3c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("97c38df6-d093-4622-b79e-7e294e234e40"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("98792b81-13af-47b2-9b54-41b3bf012b9b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("998779d5-e47b-439e-a12e-ce254cf80a28"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("9a5807ad-9f3c-4075-97d5-ff282a269d0a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("9b2ec67e-f151-469b-92ee-cb9342bff657"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("9d7fe7db-8998-406b-9247-3ee154bc1162"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a08e797e-9cc8-4623-aac2-a706d90c3271"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a1a1f268-34bf-4092-9999-f1931d11e54d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a2acbbb6-ead1-4ad3-b4bd-75b00174acaa"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a347530b-e88f-4243-b817-10e06c0aee98"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a4ea2eb5-9173-46d3-a99c-60914016dc49"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a5a04554-18ea-4b73-9ca1-45c9b38d9442"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a5cbcf33-1a95-48b2-9aa1-e5a33935d201"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a70cbacf-1a44-4e39-9b21-7706ac4d66c1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a741bf61-7184-41e3-ac37-2dcf86e2540f"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("a9ed42dc-4688-458e-8caa-449eadd3fbd7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ad63474f-5bb4-4807-9f27-fac65a07e6e3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ada94d4e-693d-4335-85e5-e3069ec5f338"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ae2fd147-dee0-4e33-9c3b-d3ee453ceaf4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ae92f072-5c39-4ebf-bfba-2f6d5532aee9"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("aec99586-581a-4558-9088-d201b92d4871"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("afd24607-2cfb-4b83-94aa-91951ee73d07"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b03916d0-a3c1-46b6-badf-426ba65a05e6"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b040a950-43db-430b-bf78-72f9715025dc"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b2219b83-fac5-42da-af6d-e43922edfdc0"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b5d7ca8d-c5e5-4396-a476-a8345d29ba88"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b66598ec-bf69-44d0-8214-84b540468921"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b7ea6d59-e94d-4ca9-9eec-41ad87c29c22"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b9673929-d430-49a8-a7f6-06d2386c9914"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("b9ed57fd-acd1-40aa-96e2-c4556da6a27e"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("bb2776c2-bab6-4362-9be8-4b66e9980294"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("bbd95bb5-c38f-4ca8-8280-14c34df94cb7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("bff80dd8-a6a3-4369-9b96-b8e3ace6ccb4"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c1cf82cb-4be8-4953-8fd2-256f783cac61"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c4a233ae-cdbe-43e0-8f39-cf673e967be6"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c5bf8747-048d-4528-a109-64726c8052de"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c6233219-29f1-4ae9-b91a-b31656138f4d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c730b084-95ef-4c54-a6dc-d5b5757e1b22"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c7da0565-9b74-4610-97aa-f083b4a9b496"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c80d7549-fc3c-4953-89e0-3e9d173023ca"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c85f722e-96db-4abc-a78b-2ced1dd3b8ff"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c919c495-717d-4f01-8759-905607ac295a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c91c199a-ca57-4754-9b4b-07317ae04b53"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c930970c-5740-40ab-9cd8-f3fd15ef118a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("c998e780-06d2-441d-a393-54663534c478"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("cbc14f22-5bb1-471f-8334-40e6f90ea57b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("cf457336-1b04-4991-8fd4-8191b5b6b483"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d0c96f23-7dbc-434c-829e-16357d0cae2e"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d29089ae-3664-4061-be0b-12760e3d787b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d5971d4d-a58b-46ec-939c-f4c2abe6296a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d5ba46df-374e-4601-a9a8-bd9fa0819558"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d60ddc88-2bda-4da7-92ec-afb4c41aac72"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d674a0da-a8cb-4c23-8edb-59083c6c6e3a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d7b1559e-de7b-4857-aecd-894ebcfeab50"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("d88a0fd4-6c33-425f-973b-b6d1f294be1d"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("dc11c906-698a-4476-9caf-02fe4cfc28af"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("dd54b1d6-d64b-40b0-b01b-b678a9e15f08"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ddc952a1-221a-486b-805f-c21a48bca86c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("de085a6c-d8ac-4e4f-bcde-26c9bfd950bb"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("de8aaa5a-0ae4-47da-ad19-db2edc1915fe"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("df44071a-29cf-4fa8-b1b0-8c229ad2bbb8"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e03a0b7c-3d80-43b9-8eba-d617dd332de9"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e0d98857-aadb-47af-a690-15604afcd8c1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e2172ace-0bcc-478d-8f70-63be5ee7b1fa"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e2986e39-d18d-4748-8251-62ff443fafd1"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e2c8a7c6-39f0-4aad-978b-12c7c87a3b2a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e3390560-c133-42d5-925f-4e630a9276fd"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e3d5a51d-f6bd-4524-b3e3-e87e26127b77"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e4092c73-7495-4715-bb20-29b729215edb"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e43a1ef6-9d92-49f1-8bed-36eca7babb51"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e46bd880-83d6-4783-84ca-e41be0821c8c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e5e8412a-3cf8-46bb-a22c-c715a899de21"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e6f87ae8-4453-4148-a82a-d865e73a27fe"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e778c83b-5a34-4add-bd39-911c73b9e5f3"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e8c0d36a-f0ec-40eb-9668-4b741c648ce8"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e9700938-01a9-4748-a80c-3f5260a3bbd5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("e999f475-17e6-456b-b228-e169860c1bdd"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("eab7cb6b-1b7b-4757-85da-e3fe89e1e104"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("eb1fcdca-c6b4-4e94-bb2b-eb450ab7cdac"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("eb23ee67-abcb-49d6-9f6a-40efdfd7266e"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ebd01060-30e2-48f6-abea-78817befc48f"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ec432079-c39a-42b8-99c8-3b4ad2142976"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ec4b5f9c-cf23-463b-8f58-47ed3cca6ca7"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ecd61f45-6af8-4588-842f-38ba83d67a2b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ecdb5b1b-3065-44f8-9106-6e729c339a07"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ed408421-2687-47b9-ae4a-9e8c30517858"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ed456b9a-bd6d-4996-8b5a-6261609d5c07"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ee3bb160-ec3f-4e55-87a7-1e7d01cad7fe"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ef411ceb-391a-491a-96a6-e85a053af4aa"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ef517706-edb9-42a1-8a94-281c36b9d34a"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ef7831a3-c910-47c0-88d1-2bf47b39ce76"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f3a9c739-59bf-4705-a1c4-86a20bafeb39"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f4141f98-bf6b-455c-aed5-a8f30383cee5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f6071b44-13bc-4bee-8605-c9d3e98f579b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f67bc459-a7fb-4d14-9033-6745cd6fe432"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f6bee1a7-59a0-4a44-9813-2b271bb5719c"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f70d43a8-f531-4ea8-ba0e-438998d5bac5"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f81cd9c6-4a82-4c6b-9e7c-f9ef13425120"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f822992b-0329-4e91-ae46-eb940a6b2f00"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("f91f4cce-8ccf-4e26-9ec0-18072c7ef51b"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("fac7ee0d-3c93-49b1-b45e-72d772b23da2"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("fc031048-1b9d-4273-84ff-e03b6f96d5ac"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("fe505e3f-b221-485d-a2f8-bdacc5bd46ba"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("fedf6626-1534-46a3-8cce-da336c109603"));

            migrationBuilder.DeleteData(
                table: "Musicans",
                keyColumn: "Id",
                keyValue: new Guid("ff846b37-5a1e-4237-a488-b22240d8cbf1"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("0169c78a-7978-4bf9-ad73-bb8879964c4c"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("029e6be6-9017-49e5-a3af-0028a98d789b"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("18312087-d12f-4d2e-83f4-b0779ea06739"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("208ee550-3a61-44c3-ae94-d76f93a737e6"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("32cd7168-78eb-4f2d-b346-53759321e307"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("387d78ae-cc2f-493d-a64f-b1c9efeb5e47"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("3e83526c-d4bb-46c1-bad9-37172471ea70"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("41c9685d-576b-4a64-be73-abde07de3b60"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("4e2d3b03-a726-4efd-b648-cb27ba05f2a7"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("4fe428f7-d3aa-4446-9a3a-fc3ae0695c4d"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("50ce9183-328f-446c-97d9-4679591dc5f4"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("93a00a1e-d808-4070-80d9-2a7a681c4d7f"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("97851fb9-bd0e-4535-aea1-a2dfaef57380"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("9d0e4990-01a1-4d99-851d-6f19e8b64825"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("9df44fe0-798d-417d-9fb2-341c81e05a0c"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("a94883fa-9c43-4220-8c2a-05b0957055c9"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("b228f121-ddc0-47ea-88ca-f751a7e1d87b"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("cf9c3983-8099-4231-b009-8e8d097dc767"));

            migrationBuilder.DeleteData(
                table: "PersonalTags",
                keyColumn: "Id",
                keyValue: new Guid("eb8636b8-edba-4f88-8ac6-01dfb9e5cb5b"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("024724b5-9241-4162-8819-c1c02d2d424f"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("073dcd58-ca49-47ea-a4d1-7da08ecc0bc5"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("0a6727e8-68e2-4e69-a5f8-59d12181414d"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("0d1ad3bf-857a-40e2-adb1-80438efadbf9"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("11425436-c405-457b-aa7b-b1c00b33b0f1"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("15b1deca-bf5a-4cba-a0b5-72811f6a7dc2"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("1b669786-7838-4d81-a9e4-9cf7996236e2"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("1fdcd989-df9b-4fec-99c9-3d03b982842a"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("21437ee7-d5e6-4e3a-8c97-5692e8fef517"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("244eb6da-5636-4e82-b9cd-744ab210c7aa"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("25c1b108-ebf3-4135-946f-2195327dd424"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("2f25c623-2b2c-49fa-b98e-5857c8e9d099"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("35b899e5-04f8-453b-a136-28d299443212"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("37292637-29ed-43f4-b721-dfa65e26cb97"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("45d8fd67-ce45-4dec-86ef-7b000661bf8c"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("4b63807c-b403-4347-9793-639ea44257b8"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("51ac6ca6-4e96-4aa0-8e94-f25867a2ca39"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("52b4281f-4203-47ad-b292-61467fe195f8"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("544a6e91-232c-4334-939d-3ead889fc084"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("5a08582b-2d1a-4694-b16d-45fadae689c0"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("5b4d5676-e486-47d5-a8f0-0115337b8ba5"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("5c98a29f-dc78-4962-85eb-824bcdd2c67d"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("5f100308-ed5d-483f-9240-87f149cf37b2"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("65bb8bb6-c8fd-4f78-a256-e996cd13f5fc"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("678dbdc3-c084-4031-b218-bc63808efb2d"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("6896d070-649a-4a72-8b9c-05fdb01d7e91"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("6bcab5a5-7005-4bd8-b075-2bc30865b516"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("6d317001-ca50-4a0a-b657-36c3792f4fc0"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("818f0525-2323-4647-8ec1-61d8c44374b0"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("8207c3f2-d983-4c79-a47f-5ae676e5cfcd"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("82286095-7582-4d64-8cd2-63eb404a1e41"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("8a12aee1-c677-4a98-a7e7-923dfad0d5d1"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("92614014-031f-4a9e-b8ff-b46273c62c44"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("95dc98c0-ae99-4745-9d25-cdb4834ad64f"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("9df4a59c-bff7-4f1a-a994-1a22ad4e87ed"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("a055c605-092b-4da6-be11-06cde482ba6b"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("a2803d14-bdc1-4b41-b965-f3bb9a91b60b"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("a927560e-bbef-43ae-bcbf-1e3fe22a495f"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("aa5c4783-d448-4847-b798-58b47bc59e15"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("ae016554-6c27-49f0-99bb-10158a8d6072"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("b4749593-1a50-4e51-baed-4555528f1466"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("c206c38c-b1e6-4cc5-aaba-5d6e4107e13c"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("c27f232a-8725-4d9d-a88f-c902aee031d5"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("cae10fb6-449a-48c6-92c6-13157b7cd26a"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("ce879ad7-dd8a-44db-b649-d2e8be01298e"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("d3fa4a75-3995-4cd5-8722-da495d5c63ce"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("da0a0012-64c7-41ef-b2a3-0c335a264a89"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("da5df2bb-4d35-4f08-bd2d-beed64bab740"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("f0950729-e5b3-4366-a63b-2f4a5e29e7f6"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("f3ad64e9-f8ef-4393-95af-96866706f8eb"));

            migrationBuilder.DeleteData(
                table: "TVMedias",
                keyColumn: "Id",
                keyValue: new Guid("fb58fad1-586a-467f-aa2a-b64bc5000fcc"));
        }
    }
}
