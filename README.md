# RegionalStringCleaner
A simpler, pared-down version of a project I did for work.  This project checks a string for unacceptable characters and, depending on regional rules, either replaces them with acceptable strings or truncates them.  This project includes the library, unit tests, and a windows form to try out the library with.  Made in Visual Studio Community 2015 using .NET 4.5.2

----------
HOW TO RUN

Run the RegionalStringCleanerForm to try out the library.  You will only be able to use the EPC region settings for now.

----------
TEST STRINGS FOR THE FORM

1) A string that will be accepted with no replacements and no truncations:
()+,-./0123456789:?ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz 

2) A string that will have every character replaced (note: some chars are replaced with more than one char, so the resulting string will be longer):
;[\]_`{|}~¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõöøùúûüýþÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĲĳĴĵĶķĹĺĻļĽľĿŀŁłŃńŅņŇňŐőŒœŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰűŲųŴŵŶŷŸŹźŻżŽžȘșȚțΆΈΉΊΌΎΏΪΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩΪΫάέήίΰαβγδεζηθικλμνξοπρςστυφχψωϊϋόύώАБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯабвгдежзийклмнопрстуфхцчшщъьюя€

3) A string that will be entirely deleted:
ٶٸٻټٽٿځڃڅڇډڎڑړږکڤڠڝڙ

