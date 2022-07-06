Final Work
Choosen page for automated testing is: https://www.manoapklausa.lt/

TestCase1: Check if a warning appears when editing an already created survey:
1. Open page https://www.manoapklausa.lt/;
2. Login to page;
3. Click "Taisyti" on survey named "Vasara";
4. Click "Gerai" on the alert;
5. Click "Issaugoti pakeitimus";
6. Compare actual text with expected text after clicking "Issaugoti pakeitimus" button. If Assert is True test is successful;
7. Close the driver.

TestCase2: Create survey:
1. Open page https://www.manoapklausa.lt/;
2. Login to page;
3. Click "Sukurti" button;
4. Click "Sukurti nauja apklausa";
5. Write survey name "Vasara";
6. Write survey description "Trumpas klausimynas apie vasara";
7. Click "Testi" button;
8. Click "Prideti klausima";
9. Send keys "Kiek menesiu turi vasara?" to "Klausimas" textbox;
10. Send keys "Vienas" to atsakymas1 textbox;
11. Send keys "Du" to atsakymas2 textbox;
12. Send keys "Trys" to atsakymas3 textbox;
13. Click button "Saugoti";
14. Click button "BaihtiApklausa";
15. Compare actual text with expected text after clicking "Issaugoti pakeitimus" button. If Assert is True test is successful;
16. Close the driver.

TestCase3: Fill in the created survey:
1. Open page https://www.manoapklausa.lt/;
2. Login to page;
3. Click on survey "Vasara";
4. Switch to new survey window;
5. Click "Pradeti" button than it's clickable;
6. Click on "moteris" in fied "lytis";
7. Click on "20" in field "amzius";
8. Click on "Klaipedos apskritis" in field "Gyvenamoji vieta";
9. Click button "Testi";
10. Click third check box ("Trys");
11. Click button "Testi";
12. Compare actual text with expected text after clicking "Testi" button. If Assert is True test is successful;
13. Close the driver.

TestCase4: Fill not all fiels in created survey
1. Open page https://www.manoapklausa.lt/;
2. Login to page;
3. Click on survey "Vasara";
4. Switch to new survey window;
5. Click "Pradeti" button than it's clickable;
6. Click on "moteris" in fied "lytis";
7. Click on "20" in field "amzius";
8. Click "Testi" button;
12. Compare actual text with expected text after clicking "Testi" button. If Assert is True test is successful;
13. Close the driver.

TestCase5: Check if a warning appears when password is incorrect:
1. Open page https://www.manoapklausa.lt/;
2. Send Keys "dovile.skujiene@gmail.com" on field "El. pastas";
3. Send Keys "Skujien" on field "slaptazodis";
4. Click "Prisijungti button";
5. Compare actual text with expected text after clicking "Testi" button. If Assert is True test is successful;
6. Close the driver.


