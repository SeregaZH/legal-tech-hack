﻿using src.Service.Document;
using Xunit;

namespace tests
{
    public class RegexTests
    {
        private ITextParserService textParserService;

        public RegexTests()
        {
            textParserService = new TextParserService();
        }

        [Fact]
        public void GetCovenantResults()
        {
            var result = textParserService.GetCovenantResults(text);
            Assert.True(result.Count == 11);
        }

        private string text = @"ДОГОВОР АРЕНДЫ 
 нежилого помещения 
№ 234

г. Минск						                              01 января 2015 

Открытое акционерное общество «Хорошая компания», именуемое в дальнейшем «Арендодатель», в лице директора Иванова И.И., действующего на основании Устава, с одной стороны и
общество с ограниченной ответственностью «Отличная компания», именуемое в дальнейшем «Арендатор», в лице Генерального директора Петрова И.И., действующего на основании Устава, с другой стороны, совместно именуемые «Стороны», заключили настоящий договор (далее – «Договор») о нижеследующем:

1. ПРЕДМЕТ ДОГОВОРА
1.1. Арендодатель предоставляет, а Арендатор принимает во временное владение и пользование нежилые помещения, расположенные в здании по адресу: Республика Беларусь, г. Минск, проспект Н., дом 65, общей площадью 4000  кв.м. в том числе:
- здание административного помещения – 3000,0 кв.м. (далее «Помещение № 1», в составе офисных и технических помещений, помещений общественного питания с технологическим оборудованием и инвентарем согласно Приложению №6.
- здание административно-хозяйственное – 500 кв.м. (далее «Помещение № 2» в составе офисных и технических помещений).
- здание специализированного назначения – 300 кв.м. (далее – «Помещение  №3).
- помещения неустановленного назначения – 200 кв.м. (далее – «Помещение  №4).
Характеристики Помещения №1 представлены в Копии Технического паспорта на нежилое здание (сооружение), выданного Республиканским унитарным предприятием «Минское городское агентство по государственной регистрации и земельному кадастру» (далее – «Регистрирующий орган») по состоянию на 14.02.2008 Копия технического паспорта прилагается (Приложение №1).
Характеристики Помещения №2 представлены в копии Технического паспорта на нежилое здание (сооружение), выданного Регистрирующим органом по состоянию на 14.02.2008г. Копия технического паспорта прилагается (Приложение №2).
Характеристики Помещения №3 представлены в копии Технического паспорта на нежилое здание (сооружение), выданного Регистрирующим органом по состоянию на 14.02.2008г. Копия технического паспорта прилагается (Приложение №3).
Характеристики Помещения №4 представлены в копии Технического паспорта на нежилое здание (сооружение), выданного Республиканским унитарным предприятием «Минское городское агентство по государственной регистрации и земельному кадастру» (далее – «Регистрирующий орган») по состоянию на 14.02.2008г. Копия технического паспорта прилагается (Приложение №1).
1.2. Арендатор использует Помещения для размещения офиса, технологического оборудования.
1.3. Арендодатель является собственником Помещений 
1.4. Арендодатель гарантирует, что на момент заключения настоящего договора помещения не проданы, не заложены, не обременены правами третьих лиц.
1.5. Договор вступает в силу с даты подписания сторонами. Срок действия договора устанавливается до 31.08.2019 года.


2. РАЗМЕР АРЕНДНОЙ ПЛАТЫ И ПОРЯДОК РАСЧЕТОВ

2.1. Сумма ежемесячной арендной платы составляет 2 000 (две тысячи)  российских рублей без НДС.. НДС уплачивается в порядке, установленном международными договорами, участниками которых являются Российская Федерация и Республика Беларусь. Расчет стоимости арендной платы прилагается (Приложение №5).
Оплата арендной платы осуществляется в российских рублях.
2.2. Арендная плата по п. 2.1. настоящего договора производится Арендатором ежемесячно, начиная с даты подписания Акта приема-передачи, в срок до 15 (пятнадцатого) числа текущего месяца. Арендатор предоставляет Арендодателю в срок до 20 (двадцатого) числа отчетного месяца копию платежного поручения о перечислении суммы арендной платы по адресу: Республика Беларусь, город Минск, ул. Радужная, 25. Копия платежного поручения должна содержать отметку обслуживающего банка о проведении платежа.
2.3. Размер арендной платы, указанный в п.2.1. настоящего договора, может изменяться в одностороннем порядке по инициативе Арендодателя, но не чаще одного раза в год. О предстоящем изменении размера арендной платы Арендатор извещается Арендодателем не позднее, чем за 30 календарных дней.
2.4. По взаимному соглашению Сторон Арендатор может произвести досрочную оплату, предварительно известив Арендодателя о сумме и сроках ее внесения.
2.5. Возмещение стоимости  коммунальных услуг (отопление, горячее и холодное водоснабжение, канализация, электроэнергия, телефонизация, уборка прилегающей территории) осуществляется Арендатором на основании счета Арендодателя, который направляется Арендатору не позднее 25 числа месяца, следующего за отчетным. Счета оплачиваются в течение 5 дней с момента их выставления. 

3. ПРАВА И ОБЯЗАННОСТИ СТОРОН

3.1. Арендодатель обязуется:
3.1.1. В пятидневный срок с даты подписания настоящего Договора передать Арендатору Помещение по Акту приема-передачи, в котором отражается подробное описание технического состояния и назначения Помещения, а также находящегося в нем имущества, передаваемого в пользование Арендатору, на момент его передачи.
3.1.2. Оказывать содействие Арендатору в поддержании Помещения в технически исправном состоянии, в организации Арендатором собственной охраны, связи, проведении ремонтных работ.
3.1.3. Обеспечивать надлежащее функционирование систем жизнеобеспечения и инженерных систем Помещения, производить капитальный ремонт Помещения, занимаемого Арендатором.
3.1.4. В случае аварий, произошедших не по вине Арендатора, немедленно принять все необходимые меры по устранению аварий и их последствий.
3.1.5.В течение всего срока аренды обеспечивать условия для нормального использования Помещения Арендатором в соответствии с назначением, указанным в п.1.2. настоящего договора.

3.2. Арендатор обязуется:

3.2.1. Использовать Помещение исключительно по прямому назначению, указанному в п. 1.2. настоящего договора.
3.2.2. Не производить без письменного согласия Арендодателя  перепланировку и переоборудования, а также любые виды ремонтных и строительных работ, влекущих изменения технических характеристик Помещений и зданий. 
3.2.3. В случае осуществления с согласия Арендодателя  перепланировки, переоборудования, реконструкции и иных видов работ, влекущих за собой изменение технических или иных характеристик Помещения, Арендатор обязан в течение двух месяцев после проведения указанных работ обеспечить проведение необходимых организационных и иных мероприятий по осуществлению государственной регистрации и технической инвентаризации Помещения с предоставлением в адрес Арендодателя всех полученных в результате государственной регистрации и технической инвентаризации документов. Арендатор несет ответственность за соблюдение требований законодательства Республики Беларусь в отношении Помещения в области пожарной безопасности, охраны труда, санитарно-эпидемического благополучия населения.
3.2.4. Соблюдать установленные требования по пропускному и внутриобъектному режиму. В случае невозможности обеспечения противопожарного и охранно-пропускного режима со стороны Арендатора вопрос обеспечения режима решается Сторонами дополнительно по отдельному договору.
3.2.5. Осуществлять допуск представителей Арендодателя в арендуемое Помещение в целях осуществления контроля использования Помещения.
3.2.6. В установленные сроки вносить арендную плату, осуществлять оплату коммунальных услуг, а также возмещать материальный ущерб, причиненный арендуемому Помещению, имуществу, оборудованию и инвентарю Арендодателя по вине Арендатора или третьих лиц.
3.2.7. Незамедлительно устранять последствия аварий и повреждений арендуемого Помещения, произошедших по вине Арендатора или по вине третьих лиц.
3.2.8. Не менее одного раза в 3 года производить за свой счет текущий ремонт в арендуемом Помещении, а также осуществлять ремонт фасада здания и прилегающей территории по согласованию с Арендодателем.
В случае, если ремонт не произведен, Арендатор должен в течение 30 дней возместить Арендодателю его стоимость при досрочном расторжении Договора или по окончании срока действия Договора.
3.2.9. Арендатор не вправе без согласия Арендодателя сдавать арендованное помещение в субаренду третьим лицам, предоставлять Помещение в безвозмездное пользование, а также отдавать арендные права в залог и вносить их в качестве паевого взноса или вклада в уставный фонд.
3.2.10. Арендатор является собственником отходов, образующихся в результате осуществления его деятельности, и самостоятельно организует вывоз данных отходов.
3.2.11. Арендатор обязан застраховать в уполномоченной страховой организации в пользу Арендодателя риски гибели и повреждения переданного в аренду Помещения на весь срок действия Договора, с представлением надлежащим образом оформленного страхового полиса, на сумму не менее 100% стоимости имущества.
3.2.12. Арендатор обязан сообщить в письменном виде Арендодателю не менее чем за 3 (три) месяца до окончания срока действия Договора о своем намерении продлить действие настоящего Договора.
3.2.13. По истечении срока Договора, а также при досрочном его прекращении передать Арендодателю все произведенные в арендуемом Помещении перестройки и переделки, согласованные в установленном порядке с Арендодателем и уполномоченными органами/организациями, а также все улучшения, составляющие принадлежность Помещения и неотделимые от конструкций здания без ущерба для них. Арендатор не имеет права на возмещение стоимости неотделимых улучшений Помещений, за исключением случаев, когда письменным соглашением Сторон установлено иное.
3.3. Арендодатель имеет право производить текущий ремонт в сдаваемом в аренду помещении за свой счет.

4. ОТВЕТСТВЕННОСТЬ СТОРОН

4.1. Стороны несут ответственность за невыполнение условий и обязательств по настоящему договору в соответствии с действующим законодательством.
4.2. Ответственность Арендатора:
4.2.1. В случае повреждения арендуемого Помещения и имущества не по вине Арендодателя, Арендатор обязан возместить нанесенный Арендодателю ущерб или произвести необходимый ремонт за свой счет.
4.2.2. В случае задержки освобождения арендуемого Помещения по истечении срока или при расторжении настоящего Договора в период, после его продления согласно п.5.5. настоящего Договора, Арендодатель вправе потребовать от Арендатора уплаты пени в размере 0,1% от суммы годовой арендной платы за каждый день просрочки передачи помещения.
4.2.3. При неуплате в установленные сроки арендной платы и других платежей Арендодатель вправе потребовать от Арендатора уплаты пени в размере 0,1% от суммы просроченного платежа за каждый день просрочки.
4.2.4. Уплата неустойки не освобождает Арендатора от выполнения принятых на себя обязательств по настоящему Договору.
4.3. Ответственность Арендодателя:
4.3.1. В случае повреждения имущества или оборудования Арендатора, находящегося в Помещении или причинения ущерба самому Помещению в результате аварий, произошедших по вине Арендодателя, Арендатор вправе потребовать от Арендодателя в судебном порядке заменить поврежденное имущество и оборудование, произвести за свой счет необходимый ремонт, либо по соглашению Сторон возместить расходы по устранению повреждений.
4.4. Условия п.п.4.2.2. и 4.2.3. применяются в случае направления Стороной, имеющей право на получение неустойки, соответствующего письменного требования.

5. ПОРЯДОК ИЗМЕНЕНИЯ И РАСТОРЖЕНИЯ ДОГОВОРА

5.1. Изменение условий Договора и его расторжение допускается по соглашению Сторон, кроме случаев, указанных в п.п. 5.2., 5.3. настоящего Договора, а также в случае наступления форс-мажорных обстоятельств, препятствующих исполнению обязательств по Договору.
5.2.Арендодатель имеет право одностороннего отказа от исполнения договора (расторгнуть настоящий Договор в одностороннем внесудебном порядке) предварительно письменно уведомив об этом Арендатора не менее чем за 30 (тридцать) календарных дней в целом или в части, в следующих случаях:
- если пользуется имуществом и оборудованием с существенными нарушениями условий Договора или назначением имущества и оборудования либо с неоднократными нарушениями условий Договора;
- если существенно ухудшает имущество и оборудование;
- если более двух месяцев после установленного срока платежа не вносит арендную плату;
- Арендодатель также вправе требовать расторжения Договора в случае перепланирования Арендатором Помещения или изменения внешнего вида здания без согласования с Арендодателем. 
5.3. При расторжении Договора передача Арендодателю Помещения и используемого имущества и оборудования производится по Акту приема-передачи по истечении срока действия настоящего Договора либо не позднее 15 дней с даты письменного уведомления о расторжении Договора в соответствии с п.п. 5.2  настоящего Договора. Арендатор обязан оплатить стоимость аренды помещения до фактического момента их возврата.
5.4. Арендатор при надлежащем выполнении им всех условий настоящего Договора имеет преимущественное перед другими лицами право на продление договорных отношений (по аренде Помещений) с Арендодателем.

6. ПОРЯДОК  РАССМОТРЕНИЯ  СПОРОВ.

6.1. Все споры и разногласия, возникающие между Сторонами при исполнении настоящего Договора, разрешаются путем переговоров.
6.2. В случае невозможности разрешения споров и разногласий путем переговоров они передаются на рассмотрение суда в следующем порядке:
- споры, предметом которых являются Помещения, в том числе об установлении факта владения Помещениями или прав на них, подлежат разрешению в Экономическом суде, являются нормы права Республики Беларусь;
- все иные споры, разногласия и требования, вытекающие из настоящего Договора, подлежат разрешению в Международном коммерческом арбитражном суде при Торгово-промышленной палате Российской Федерации в соответствии с его Регламентом; материальными нормами, применимыми к существу спора, являются нормы права Республики Беларусь.

7. ДРУГИЕ  УСЛОВИЯ  ДОГОВОРА.

7.1. Все изменения к настоящему Договору должны быть выполнены в той же форме и с соблюдением тех же условий заключения, что и сам Договор.
7.2. Реорганизация Арендодателя, а также перемена собственника арендуемого Помещения, не являются основанием для пересмотра условий или расторжения настоящего Договора.
7.3. Арендатор вправе самостоятельно заключать договоры на организацию охраны Помещения,  проведение ремонтных и иных работ.
7.4. Настоящий Договор составлен в двух экземплярах, имеющих одинаковую юридическую силу, по одному экземпляру для Арендодателя и Арендатора.  

8. ЮРИДИЧЕСКИЕ  АДРЕСА  И  РЕКВИЗИТЫ  СТОРОН.

Арендодатель: 
Арендатор:  



Арендодатель	Арендатор


___________________			                                           ________________ 
";
    }
}
