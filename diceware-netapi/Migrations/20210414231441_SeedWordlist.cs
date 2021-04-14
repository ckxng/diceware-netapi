using Microsoft.EntityFrameworkCore.Migrations;

namespace diceware_netapi.Migrations
{
    public partial class SeedWordlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11111,'abacus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11112,'abdomen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11113,'abdominal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11114,'abide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11115,'abiding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11116,'ability');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11121,'ablaze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11122,'able');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11123,'abnormal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11124,'abrasion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11125,'abrasive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11126,'abreast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11131,'abridge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11132,'abroad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11133,'abruptly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11134,'absence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11135,'absentee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11136,'absently');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11141,'absinthe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11142,'absolute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11143,'absolve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11144,'abstain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11145,'abstract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11146,'absurd');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11151,'accent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11152,'acclaim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11153,'acclimate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11154,'accompany');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11155,'account');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11156,'accuracy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11161,'accurate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11162,'accustom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11163,'acetone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11164,'achiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11165,'aching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11166,'acid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11211,'acorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11212,'acquaint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11213,'acquire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11214,'acre');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11215,'acrobat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11216,'acronym');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11221,'acting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11222,'action');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11223,'activate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11224,'activator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11225,'active');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11226,'activism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11231,'activist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11232,'activity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11233,'actress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11234,'acts');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11235,'acutely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11236,'acuteness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11241,'aeration');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11242,'aerobics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11243,'aerosol');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11244,'aerospace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11245,'afar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11246,'affair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11251,'affected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11252,'affecting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11253,'affection');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11254,'affidavit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11255,'affiliate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11256,'affirm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11261,'affix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11262,'afflicted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11263,'affluent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11264,'afford');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11265,'affront');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11266,'aflame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11311,'afloat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11312,'aflutter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11313,'afoot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11314,'afraid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11315,'afterglow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11316,'afterlife');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11321,'aftermath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11322,'aftermost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11323,'afternoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11324,'aged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11325,'ageless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11326,'agency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11331,'agenda');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11332,'agent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11333,'aggregate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11334,'aghast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11335,'agile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11336,'agility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11341,'aging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11342,'agnostic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11343,'agonize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11344,'agonizing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11345,'agony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11346,'agreeable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11351,'agreeably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11352,'agreed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11353,'agreeing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11354,'agreement');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11355,'aground');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11356,'ahead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11361,'ahoy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11362,'aide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11363,'aids');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11364,'aim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11365,'ajar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11366,'alabaster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11411,'alarm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11412,'albatross');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11413,'album');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11414,'alfalfa');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11415,'algebra');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11416,'algorithm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11421,'alias');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11422,'alibi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11423,'alienable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11424,'alienate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11425,'aliens');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11426,'alike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11431,'alive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11432,'alkaline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11433,'alkalize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11434,'almanac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11435,'almighty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11436,'almost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11441,'aloe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11442,'aloft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11443,'aloha');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11444,'alone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11445,'alongside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11446,'aloof');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11451,'alphabet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11452,'alright');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11453,'although');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11454,'altitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11455,'alto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11456,'aluminum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11461,'alumni');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11462,'always');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11463,'amaretto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11464,'amaze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11465,'amazingly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11466,'amber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11511,'ambiance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11512,'ambiguity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11513,'ambiguous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11514,'ambition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11515,'ambitious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11516,'ambulance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11521,'ambush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11522,'amendable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11523,'amendment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11524,'amends');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11525,'amenity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11526,'amiable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11531,'amicably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11532,'amid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11533,'amigo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11534,'amino');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11535,'amiss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11536,'ammonia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11541,'ammonium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11542,'amnesty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11543,'amniotic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11544,'among');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11545,'amount');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11546,'amperage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11551,'ample');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11552,'amplifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11553,'amplify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11554,'amply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11555,'amuck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11556,'amulet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11561,'amusable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11562,'amused');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11563,'amusement');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11564,'amuser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11565,'amusing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11566,'anaconda');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11611,'anaerobic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11612,'anagram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11613,'anatomist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11614,'anatomy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11615,'anchor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11616,'anchovy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11621,'ancient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11622,'android');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11623,'anemia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11624,'anemic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11625,'aneurism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11626,'anew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11631,'angelfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11632,'angelic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11633,'anger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11634,'angled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11635,'angler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11636,'angles');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11641,'angling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11642,'angrily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11643,'angriness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11644,'anguished');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11645,'angular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11646,'animal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11651,'animate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11652,'animating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11653,'animation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11654,'animator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11655,'anime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11656,'animosity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11661,'ankle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11662,'annex');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11663,'annotate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11664,'announcer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11665,'annoying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (11666,'annually');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12111,'annuity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12112,'anointer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12113,'another');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12114,'answering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12115,'antacid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12116,'antarctic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12121,'anteater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12122,'antelope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12123,'antennae');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12124,'anthem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12125,'anthill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12126,'anthology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12131,'antibody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12132,'antics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12133,'antidote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12134,'antihero');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12135,'antiquely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12136,'antiques');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12141,'antiquity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12142,'antirust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12143,'antitoxic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12144,'antitrust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12145,'antiviral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12146,'antivirus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12151,'antler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12152,'antonym');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12153,'antsy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12154,'anvil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12155,'anybody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12156,'anyhow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12161,'anymore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12162,'anyone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12163,'anyplace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12164,'anything');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12165,'anytime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12166,'anyway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12211,'anywhere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12212,'aorta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12213,'apache');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12214,'apostle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12215,'appealing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12216,'appear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12221,'appease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12222,'appeasing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12223,'appendage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12224,'appendix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12225,'appetite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12226,'appetizer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12231,'applaud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12232,'applause');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12233,'apple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12234,'appliance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12235,'applicant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12236,'applied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12241,'apply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12242,'appointee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12243,'appraisal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12244,'appraiser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12245,'apprehend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12246,'approach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12251,'approval');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12252,'approve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12253,'apricot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12254,'april');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12255,'apron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12256,'aptitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12261,'aptly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12262,'aqua');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12263,'aqueduct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12264,'arbitrary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12265,'arbitrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12266,'ardently');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12311,'area');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12312,'arena');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12313,'arguable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12314,'arguably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12315,'argue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12316,'arise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12321,'armadillo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12322,'armband');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12323,'armchair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12324,'armed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12325,'armful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12326,'armhole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12331,'arming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12332,'armless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12333,'armoire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12334,'armored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12335,'armory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12336,'armrest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12341,'army');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12342,'aroma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12343,'arose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12344,'around');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12345,'arousal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12346,'arrange');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12351,'array');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12352,'arrest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12353,'arrival');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12354,'arrive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12355,'arrogance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12356,'arrogant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12361,'arson');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12362,'art');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12363,'ascend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12364,'ascension');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12365,'ascent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12366,'ascertain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12411,'ashamed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12412,'ashen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12413,'ashes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12414,'ashy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12415,'aside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12416,'askew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12421,'asleep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12422,'asparagus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12423,'aspect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12424,'aspirate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12425,'aspire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12426,'aspirin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12431,'astonish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12432,'astound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12433,'astride');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12434,'astrology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12435,'astronaut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12436,'astronomy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12441,'astute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12442,'atlantic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12443,'atlas');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12444,'atom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12445,'atonable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12446,'atop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12451,'atrium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12452,'atrocious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12453,'atrophy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12454,'attach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12455,'attain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12456,'attempt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12461,'attendant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12462,'attendee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12463,'attention');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12464,'attentive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12465,'attest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12466,'attic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12511,'attire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12512,'attitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12513,'attractor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12514,'attribute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12515,'atypical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12516,'auction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12521,'audacious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12522,'audacity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12523,'audible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12524,'audibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12525,'audience');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12526,'audio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12531,'audition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12532,'augmented');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12533,'august');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12534,'authentic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12535,'author');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12536,'autism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12541,'autistic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12542,'autograph');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12543,'automaker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12544,'automated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12545,'automatic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12546,'autopilot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12551,'available');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12552,'avalanche');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12553,'avatar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12554,'avenge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12555,'avenging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12556,'avenue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12561,'average');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12562,'aversion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12563,'avert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12564,'aviation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12565,'aviator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12566,'avid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12611,'avoid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12612,'await');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12613,'awaken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12614,'award');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12615,'aware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12616,'awhile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12621,'awkward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12622,'awning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12623,'awoke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12624,'awry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12625,'axis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12626,'babble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12631,'babbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12632,'babied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12633,'baboon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12634,'backache');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12635,'backboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12636,'backboned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12641,'backdrop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12642,'backed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12643,'backer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12644,'backfield');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12645,'backfire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12646,'backhand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12651,'backing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12652,'backlands');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12653,'backlash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12654,'backless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12655,'backlight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12656,'backlit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12661,'backlog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12662,'backpack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12663,'backpedal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12664,'backrest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12665,'backroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (12666,'backshift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13111,'backside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13112,'backslid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13113,'backspace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13114,'backspin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13115,'backstab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13116,'backstage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13121,'backtalk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13122,'backtrack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13123,'backup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13124,'backward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13125,'backwash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13126,'backwater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13131,'backyard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13132,'bacon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13133,'bacteria');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13134,'bacterium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13135,'badass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13136,'badge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13141,'badland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13142,'badly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13143,'badness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13144,'baffle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13145,'baffling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13146,'bagel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13151,'bagful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13152,'baggage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13153,'bagged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13154,'baggie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13155,'bagginess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13156,'bagging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13161,'baggy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13162,'bagpipe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13163,'baguette');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13164,'baked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13165,'bakery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13166,'bakeshop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13211,'baking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13212,'balance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13213,'balancing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13214,'balcony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13215,'balmy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13216,'balsamic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13221,'bamboo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13222,'banana');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13223,'banish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13224,'banister');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13225,'banjo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13226,'bankable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13231,'bankbook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13232,'banked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13233,'banker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13234,'banking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13235,'banknote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13236,'bankroll');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13241,'banner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13242,'bannister');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13243,'banshee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13244,'banter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13245,'barbecue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13246,'barbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13251,'barbell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13252,'barber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13253,'barcode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13254,'barge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13255,'bargraph');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13256,'barista');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13261,'baritone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13262,'barley');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13263,'barmaid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13264,'barman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13265,'barn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13266,'barometer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13311,'barrack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13312,'barracuda');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13313,'barrel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13314,'barrette');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13315,'barricade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13316,'barrier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13321,'barstool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13322,'bartender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13323,'barterer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13324,'bash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13325,'basically');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13326,'basics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13331,'basil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13332,'basin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13333,'basis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13334,'basket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13335,'batboy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13336,'batch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13341,'bath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13342,'baton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13343,'bats');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13344,'battalion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13345,'battered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13346,'battering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13351,'battery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13352,'batting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13353,'battle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13354,'bauble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13355,'bazooka');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13356,'blabber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13361,'bladder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13362,'blade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13363,'blah');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13364,'blame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13365,'blaming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13366,'blanching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13411,'blandness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13412,'blank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13413,'blaspheme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13414,'blasphemy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13415,'blast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13416,'blatancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13421,'blatantly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13422,'blazer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13423,'blazing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13424,'bleach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13425,'bleak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13426,'bleep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13431,'blemish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13432,'blend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13433,'bless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13434,'blighted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13435,'blimp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13436,'bling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13441,'blinked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13442,'blinker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13443,'blinking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13444,'blinks');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13445,'blip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13446,'blissful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13451,'blitz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13452,'blizzard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13453,'bloated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13454,'bloating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13455,'blob');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13456,'blog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13461,'bloomers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13462,'blooming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13463,'blooper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13464,'blot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13465,'blouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13466,'blubber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13511,'bluff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13512,'bluish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13513,'blunderer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13514,'blunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13515,'blurb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13516,'blurred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13521,'blurry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13522,'blurt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13523,'blush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13524,'blustery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13525,'boaster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13526,'boastful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13531,'boasting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13532,'boat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13533,'bobbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13534,'bobbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13535,'bobble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13536,'bobcat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13541,'bobsled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13542,'bobtail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13543,'bodacious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13544,'body');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13545,'bogged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13546,'boggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13551,'bogus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13552,'boil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13553,'bok');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13554,'bolster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13555,'bolt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13556,'bonanza');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13561,'bonded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13562,'bonding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13563,'bondless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13564,'boned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13565,'bonehead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13566,'boneless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13611,'bonelike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13612,'boney');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13613,'bonfire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13614,'bonnet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13615,'bonsai');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13616,'bonus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13621,'bony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13622,'boogeyman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13623,'boogieman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13624,'book');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13625,'boondocks');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13626,'booted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13631,'booth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13632,'bootie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13633,'booting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13634,'bootlace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13635,'bootleg');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13636,'boots');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13641,'boozy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13642,'borax');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13643,'boring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13644,'borough');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13645,'borrower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13646,'borrowing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13651,'boss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13652,'botanical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13653,'botanist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13654,'botany');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13655,'botch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13656,'both');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13661,'bottle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13662,'bottling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13663,'bottom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13664,'bounce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13665,'bouncing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (13666,'bouncy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14111,'bounding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14112,'boundless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14113,'bountiful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14114,'bovine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14115,'boxcar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14116,'boxer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14121,'boxing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14122,'boxlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14123,'boxy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14124,'breach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14125,'breath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14126,'breeches');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14131,'breeching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14132,'breeder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14133,'breeding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14134,'breeze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14135,'breezy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14136,'brethren');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14141,'brewery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14142,'brewing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14143,'briar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14144,'bribe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14145,'brick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14146,'bride');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14151,'bridged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14152,'brigade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14153,'bright');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14154,'brilliant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14155,'brim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14156,'bring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14161,'brink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14162,'brisket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14163,'briskly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14164,'briskness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14165,'bristle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14166,'brittle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14211,'broadband');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14212,'broadcast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14213,'broaden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14214,'broadly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14215,'broadness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14216,'broadside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14221,'broadways');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14222,'broiler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14223,'broiling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14224,'broken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14225,'broker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14226,'bronchial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14231,'bronco');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14232,'bronze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14233,'bronzing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14234,'brook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14235,'broom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14236,'brought');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14241,'browbeat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14242,'brownnose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14243,'browse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14244,'browsing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14245,'bruising');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14246,'brunch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14251,'brunette');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14252,'brunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14253,'brush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14254,'brussels');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14255,'brute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14256,'brutishly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14261,'bubble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14262,'bubbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14263,'bubbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14264,'buccaneer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14265,'bucked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14266,'bucket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14311,'buckle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14312,'buckshot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14313,'buckskin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14314,'bucktooth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14315,'buckwheat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14316,'buddhism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14321,'buddhist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14322,'budding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14323,'buddy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14324,'budget');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14325,'buffalo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14326,'buffed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14331,'buffer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14332,'buffing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14333,'buffoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14334,'buggy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14335,'bulb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14336,'bulge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14341,'bulginess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14342,'bulgur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14343,'bulk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14344,'bulldog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14345,'bulldozer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14346,'bullfight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14351,'bullfrog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14352,'bullhorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14353,'bullion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14354,'bullish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14355,'bullpen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14356,'bullring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14361,'bullseye');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14362,'bullwhip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14363,'bully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14364,'bunch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14365,'bundle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14366,'bungee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14411,'bunion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14412,'bunkbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14413,'bunkhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14414,'bunkmate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14415,'bunny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14416,'bunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14421,'busboy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14422,'bush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14423,'busily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14424,'busload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14425,'bust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14426,'busybody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14431,'buzz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14432,'cabana');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14433,'cabbage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14434,'cabbie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14435,'cabdriver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14436,'cable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14441,'caboose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14442,'cache');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14443,'cackle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14444,'cacti');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14445,'cactus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14446,'caddie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14451,'caddy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14452,'cadet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14453,'cadillac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14454,'cadmium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14455,'cage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14456,'cahoots');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14461,'cake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14462,'calamari');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14463,'calamity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14464,'calcium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14465,'calculate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14466,'calculus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14511,'caliber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14512,'calibrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14513,'calm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14514,'caloric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14515,'calorie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14516,'calzone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14521,'camcorder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14522,'cameo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14523,'camera');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14524,'camisole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14525,'camper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14526,'campfire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14531,'camping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14532,'campsite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14533,'campus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14534,'canal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14535,'canary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14536,'cancel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14541,'candied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14542,'candle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14543,'candy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14544,'cane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14545,'canine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14546,'canister');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14551,'cannabis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14552,'canned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14553,'canning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14554,'cannon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14555,'cannot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14556,'canola');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14561,'canon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14562,'canopener');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14563,'canopy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14564,'canteen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14565,'canyon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14566,'capable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14611,'capably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14612,'capacity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14613,'cape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14614,'capillary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14615,'capital');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14616,'capitol');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14621,'capped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14622,'capricorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14623,'capsize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14624,'capsule');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14625,'caption');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14626,'captivate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14631,'captive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14632,'captivity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14633,'capture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14634,'caramel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14635,'carat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14636,'caravan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14641,'carbon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14642,'cardboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14643,'carded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14644,'cardiac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14645,'cardigan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14646,'cardinal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14651,'cardstock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14652,'carefully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14653,'caregiver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14654,'careless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14655,'caress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14656,'caretaker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14661,'cargo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14662,'caring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14663,'carless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14664,'carload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14665,'carmaker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (14666,'carnage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15111,'carnation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15112,'carnival');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15113,'carnivore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15114,'carol');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15115,'carpenter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15116,'carpentry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15121,'carpool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15122,'carport');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15123,'carried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15124,'carrot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15125,'carrousel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15126,'carry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15131,'cartel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15132,'cartload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15133,'carton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15134,'cartoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15135,'cartridge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15136,'cartwheel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15141,'carve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15142,'carving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15143,'carwash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15144,'cascade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15145,'case');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15146,'cash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15151,'casing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15152,'casino');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15153,'casket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15154,'cassette');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15155,'casually');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15156,'casualty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15161,'catacomb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15162,'catalog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15163,'catalyst');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15164,'catalyze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15165,'catapult');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15166,'cataract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15211,'catatonic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15212,'catcall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15213,'catchable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15214,'catcher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15215,'catching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15216,'catchy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15221,'caterer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15222,'catering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15223,'catfight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15224,'catfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15225,'cathedral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15226,'cathouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15231,'catlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15232,'catnap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15233,'catnip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15234,'catsup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15235,'cattail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15236,'cattishly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15241,'cattle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15242,'catty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15243,'catwalk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15244,'caucasian');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15245,'caucus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15246,'causal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15251,'causation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15252,'cause');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15253,'causing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15254,'cauterize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15255,'caution');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15256,'cautious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15261,'cavalier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15262,'cavalry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15263,'caviar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15264,'cavity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15265,'cedar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15266,'celery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15311,'celestial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15312,'celibacy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15313,'celibate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15314,'celtic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15315,'cement');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15316,'census');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15321,'ceramics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15322,'ceremony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15323,'certainly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15324,'certainty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15325,'certified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15326,'certify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15331,'cesarean');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15332,'cesspool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15333,'chafe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15334,'chaffing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15335,'chain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15336,'chair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15341,'chalice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15342,'challenge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15343,'chamber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15344,'chamomile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15345,'champion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15346,'chance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15351,'change');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15352,'channel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15353,'chant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15354,'chaos');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15355,'chaperone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15356,'chaplain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15361,'chapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15362,'chaps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15363,'chapter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15364,'character');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15365,'charbroil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15366,'charcoal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15411,'charger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15412,'charging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15413,'chariot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15414,'charity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15415,'charm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15416,'charred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15421,'charter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15422,'charting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15423,'chase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15424,'chasing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15425,'chaste');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15426,'chastise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15431,'chastity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15432,'chatroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15433,'chatter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15434,'chatting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15435,'chatty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15436,'cheating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15441,'cheddar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15442,'cheek');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15443,'cheer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15444,'cheese');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15445,'cheesy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15446,'chef');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15451,'chemicals');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15452,'chemist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15453,'chemo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15454,'cherisher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15455,'cherub');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15456,'chess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15461,'chest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15462,'chevron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15463,'chevy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15464,'chewable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15465,'chewer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15466,'chewing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15511,'chewy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15512,'chief');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15513,'chihuahua');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15514,'childcare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15515,'childhood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15516,'childish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15521,'childless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15522,'childlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15523,'chili');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15524,'chill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15525,'chimp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15526,'chip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15531,'chirping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15532,'chirpy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15533,'chitchat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15534,'chivalry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15535,'chive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15536,'chloride');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15541,'chlorine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15542,'choice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15543,'chokehold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15544,'choking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15545,'chomp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15546,'chooser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15551,'choosing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15552,'choosy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15553,'chop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15554,'chosen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15555,'chowder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15556,'chowtime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15561,'chrome');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15562,'chubby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15563,'chuck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15564,'chug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15565,'chummy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15566,'chump');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15611,'chunk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15612,'churn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15613,'chute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15614,'cider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15615,'cilantro');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15616,'cinch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15621,'cinema');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15622,'cinnamon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15623,'circle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15624,'circling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15625,'circular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15626,'circulate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15631,'circus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15632,'citable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15633,'citadel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15634,'citation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15635,'citizen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15636,'citric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15641,'citrus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15642,'city');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15643,'civic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15644,'civil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15645,'clad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15646,'claim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15651,'clambake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15652,'clammy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15653,'clamor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15654,'clamp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15655,'clamshell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15656,'clang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15661,'clanking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15662,'clapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15663,'clapper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15664,'clapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15665,'clarify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (15666,'clarinet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16111,'clarity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16112,'clash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16113,'clasp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16114,'class');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16115,'clatter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16116,'clause');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16121,'clavicle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16122,'claw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16123,'clay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16124,'clean');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16125,'clear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16126,'cleat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16131,'cleaver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16132,'cleft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16133,'clench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16134,'clergyman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16135,'clerical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16136,'clerk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16141,'clever');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16142,'clicker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16143,'client');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16144,'climate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16145,'climatic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16146,'cling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16151,'clinic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16152,'clinking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16153,'clip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16154,'clique');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16155,'cloak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16156,'clobber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16161,'clock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16162,'clone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16163,'cloning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16164,'closable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16165,'closure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16166,'clothes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16211,'clothing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16212,'cloud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16213,'clover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16214,'clubbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16215,'clubbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16216,'clubhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16221,'clump');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16222,'clumsily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16223,'clumsy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16224,'clunky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16225,'clustered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16226,'clutch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16231,'clutter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16232,'coach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16233,'coagulant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16234,'coastal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16235,'coaster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16236,'coasting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16241,'coastland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16242,'coastline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16243,'coat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16244,'coauthor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16245,'cobalt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16246,'cobbler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16251,'cobweb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16252,'cocoa');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16253,'coconut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16254,'cod');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16255,'coeditor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16256,'coerce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16261,'coexist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16262,'coffee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16263,'cofounder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16264,'cognition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16265,'cognitive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16266,'cogwheel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16311,'coherence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16312,'coherent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16313,'cohesive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16314,'coil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16315,'coke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16316,'cola');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16321,'cold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16322,'coleslaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16323,'coliseum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16324,'collage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16325,'collapse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16326,'collar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16331,'collected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16332,'collector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16333,'collide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16334,'collie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16335,'collision');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16336,'colonial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16341,'colonist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16342,'colonize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16343,'colony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16344,'colossal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16345,'colt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16346,'coma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16351,'come');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16352,'comfort');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16353,'comfy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16354,'comic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16355,'coming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16356,'comma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16361,'commence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16362,'commend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16363,'comment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16364,'commerce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16365,'commode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16366,'commodity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16411,'commodore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16412,'common');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16413,'commotion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16414,'commute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16415,'commuting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16416,'compacted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16421,'compacter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16422,'compactly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16423,'compactor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16424,'companion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16425,'company');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16426,'compare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16431,'compel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16432,'compile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16433,'comply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16434,'component');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16435,'composed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16436,'composer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16441,'composite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16442,'compost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16443,'composure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16444,'compound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16445,'compress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16446,'comprised');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16451,'computer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16452,'computing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16453,'comrade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16454,'concave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16455,'conceal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16456,'conceded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16461,'concept');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16462,'concerned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16463,'concert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16464,'conch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16465,'concierge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16466,'concise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16511,'conclude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16512,'concrete');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16513,'concur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16514,'condense');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16515,'condiment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16516,'condition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16521,'condone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16522,'conducive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16523,'conductor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16524,'conduit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16525,'cone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16526,'confess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16531,'confetti');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16532,'confidant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16533,'confident');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16534,'confider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16535,'confiding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16536,'configure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16541,'confined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16542,'confining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16543,'confirm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16544,'conflict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16545,'conform');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16546,'confound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16551,'confront');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16552,'confused');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16553,'confusing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16554,'confusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16555,'congenial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16556,'congested');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16561,'congrats');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16562,'congress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16563,'conical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16564,'conjoined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16565,'conjure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16566,'conjuror');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16611,'connected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16612,'connector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16613,'consensus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16614,'consent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16615,'console');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16616,'consoling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16621,'consonant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16622,'constable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16623,'constant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16624,'constrain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16625,'constrict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16626,'construct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16631,'consult');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16632,'consumer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16633,'consuming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16634,'contact');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16635,'container');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16636,'contempt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16641,'contend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16642,'contented');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16643,'contently');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16644,'contents');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16645,'contest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16646,'context');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16651,'contort');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16652,'contour');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16653,'contrite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16654,'control');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16655,'contusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16656,'convene');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16661,'convent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16662,'copartner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16663,'cope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16664,'copied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16665,'copier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (16666,'copilot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21111,'coping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21112,'copious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21113,'copper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21114,'copy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21115,'coral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21116,'cork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21121,'cornball');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21122,'cornbread');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21123,'corncob');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21124,'cornea');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21125,'corned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21126,'corner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21131,'cornfield');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21132,'cornflake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21133,'cornhusk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21134,'cornmeal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21135,'cornstalk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21136,'corny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21141,'coronary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21142,'coroner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21143,'corporal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21144,'corporate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21145,'corral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21146,'correct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21151,'corridor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21152,'corrode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21153,'corroding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21154,'corrosive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21155,'corsage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21156,'corset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21161,'cortex');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21162,'cosigner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21163,'cosmetics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21164,'cosmic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21165,'cosmos');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21166,'cosponsor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21211,'cost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21212,'cottage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21213,'cotton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21214,'couch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21215,'cough');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21216,'could');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21221,'countable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21222,'countdown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21223,'counting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21224,'countless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21225,'country');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21226,'county');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21231,'courier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21232,'covenant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21233,'cover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21234,'coveted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21235,'coveting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21236,'coyness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21241,'cozily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21242,'coziness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21243,'cozy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21244,'crabbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21245,'crabgrass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21246,'crablike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21251,'crabmeat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21252,'cradle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21253,'cradling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21254,'crafter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21255,'craftily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21256,'craftsman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21261,'craftwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21262,'crafty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21263,'cramp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21264,'cranberry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21265,'crane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21266,'cranial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21311,'cranium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21312,'crank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21313,'crate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21314,'crave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21315,'craving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21316,'crawfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21321,'crawlers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21322,'crawling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21323,'crayfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21324,'crayon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21325,'crazed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21326,'crazily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21331,'craziness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21332,'crazy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21333,'creamed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21334,'creamer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21335,'creamlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21336,'crease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21341,'creasing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21342,'creatable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21343,'create');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21344,'creation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21345,'creative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21346,'creature');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21351,'credible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21352,'credibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21353,'credit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21354,'creed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21355,'creme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21356,'creole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21361,'crepe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21362,'crept');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21363,'crescent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21364,'crested');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21365,'cresting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21366,'crestless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21411,'crevice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21412,'crewless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21413,'crewman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21414,'crewmate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21415,'crib');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21416,'cricket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21421,'cried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21422,'crier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21423,'crimp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21424,'crimson');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21425,'cringe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21426,'cringing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21431,'crinkle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21432,'crinkly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21433,'crisped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21434,'crisping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21435,'crisply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21436,'crispness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21441,'crispy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21442,'criteria');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21443,'critter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21444,'croak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21445,'crock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21446,'crook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21451,'croon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21452,'crop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21453,'cross');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21454,'crouch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21455,'crouton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21456,'crowbar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21461,'crowd');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21462,'crown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21463,'crucial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21464,'crudely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21465,'crudeness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21466,'cruelly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21511,'cruelness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21512,'cruelty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21513,'crumb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21514,'crummiest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21515,'crummy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21516,'crumpet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21521,'crumpled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21522,'cruncher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21523,'crunching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21524,'crunchy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21525,'crusader');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21526,'crushable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21531,'crushed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21532,'crusher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21533,'crushing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21534,'crust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21535,'crux');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21536,'crying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21541,'cryptic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21542,'crystal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21543,'cubbyhole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21544,'cube');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21545,'cubical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21546,'cubicle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21551,'cucumber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21552,'cuddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21553,'cuddly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21554,'cufflink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21555,'culinary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21556,'culminate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21561,'culpable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21562,'culprit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21563,'cultivate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21564,'cultural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21565,'culture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21566,'cupbearer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21611,'cupcake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21612,'cupid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21613,'cupped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21614,'cupping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21615,'curable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21616,'curator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21621,'curdle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21622,'cure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21623,'curfew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21624,'curing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21625,'curled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21626,'curler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21631,'curliness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21632,'curling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21633,'curly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21634,'curry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21635,'curse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21636,'cursive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21641,'cursor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21642,'curtain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21643,'curtly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21644,'curtsy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21645,'curvature');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21646,'curve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21651,'curvy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21652,'cushy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21653,'cusp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21654,'cussed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21655,'custard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21656,'custodian');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21661,'custody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21662,'customary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21663,'customer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21664,'customize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21665,'customs');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (21666,'cut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22111,'cycle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22112,'cyclic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22113,'cycling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22114,'cyclist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22115,'cylinder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22116,'cymbal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22121,'cytoplasm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22122,'cytoplast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22123,'dab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22124,'dad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22125,'daffodil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22126,'dagger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22131,'daily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22132,'daintily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22133,'dainty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22134,'dairy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22135,'daisy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22136,'dallying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22141,'dance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22142,'dancing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22143,'dandelion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22144,'dander');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22145,'dandruff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22146,'dandy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22151,'danger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22152,'dangle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22153,'dangling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22154,'daredevil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22155,'dares');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22156,'daringly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22161,'darkened');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22162,'darkening');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22163,'darkish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22164,'darkness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22165,'darkroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22166,'darling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22211,'darn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22212,'dart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22213,'darwinism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22214,'dash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22215,'dastardly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22216,'data');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22221,'datebook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22222,'dating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22223,'daughter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22224,'daunting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22225,'dawdler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22226,'dawn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22231,'daybed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22232,'daybreak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22233,'daycare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22234,'daydream');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22235,'daylight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22236,'daylong');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22241,'dayroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22242,'daytime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22243,'dazzler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22244,'dazzling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22245,'deacon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22246,'deafening');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22251,'deafness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22252,'dealer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22253,'dealing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22254,'dealmaker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22255,'dealt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22256,'dean');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22261,'debatable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22262,'debate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22263,'debating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22264,'debit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22265,'debrief');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22266,'debtless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22311,'debtor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22312,'debug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22313,'debunk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22314,'decade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22315,'decaf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22316,'decal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22321,'decathlon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22322,'decay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22323,'deceased');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22324,'deceit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22325,'deceiver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22326,'deceiving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22331,'december');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22332,'decency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22333,'decent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22334,'deception');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22335,'deceptive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22336,'decibel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22341,'decidable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22342,'decimal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22343,'decimeter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22344,'decipher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22345,'deck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22346,'declared');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22351,'decline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22352,'decode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22353,'decompose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22354,'decorated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22355,'decorator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22356,'decoy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22361,'decrease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22362,'decree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22363,'dedicate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22364,'dedicator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22365,'deduce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22366,'deduct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22411,'deed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22412,'deem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22413,'deepen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22414,'deeply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22415,'deepness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22416,'deface');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22421,'defacing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22422,'defame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22423,'default');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22424,'defeat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22425,'defection');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22426,'defective');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22431,'defendant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22432,'defender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22433,'defense');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22434,'defensive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22435,'deferral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22436,'deferred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22441,'defiance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22442,'defiant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22443,'defile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22444,'defiling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22445,'define');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22446,'definite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22451,'deflate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22452,'deflation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22453,'deflator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22454,'deflected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22455,'deflector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22456,'defog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22461,'deforest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22462,'defraud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22463,'defrost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22464,'deftly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22465,'defuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22466,'defy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22511,'degraded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22512,'degrading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22513,'degrease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22514,'degree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22515,'dehydrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22516,'deity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22521,'dejected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22522,'delay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22523,'delegate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22524,'delegator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22525,'delete');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22526,'deletion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22531,'delicacy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22532,'delicate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22533,'delicious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22534,'delighted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22535,'delirious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22536,'delirium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22541,'deliverer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22542,'delivery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22543,'delouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22544,'delta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22545,'deluge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22546,'delusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22551,'deluxe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22552,'demanding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22553,'demeaning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22554,'demeanor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22555,'demise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22556,'democracy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22561,'democrat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22562,'demote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22563,'demotion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22564,'demystify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22565,'denatured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22566,'deniable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22611,'denial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22612,'denim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22613,'denote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22614,'dense');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22615,'density');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22616,'dental');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22621,'dentist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22622,'denture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22623,'deny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22624,'deodorant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22625,'deodorize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22626,'departed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22631,'departure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22632,'depict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22633,'deplete');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22634,'depletion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22635,'deplored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22636,'deploy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22641,'deport');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22642,'depose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22643,'depraved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22644,'depravity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22645,'deprecate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22646,'depress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22651,'deprive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22652,'depth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22653,'deputize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22654,'deputy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22655,'derail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22656,'deranged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22661,'derby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22662,'derived');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22663,'desecrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22664,'deserve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22665,'deserving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (22666,'designate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23111,'designed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23112,'designer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23113,'designing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23114,'deskbound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23115,'desktop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23116,'deskwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23121,'desolate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23122,'despair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23123,'despise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23124,'despite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23125,'destiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23126,'destitute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23131,'destruct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23132,'detached');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23133,'detail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23134,'detection');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23135,'detective');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23136,'detector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23141,'detention');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23142,'detergent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23143,'detest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23144,'detonate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23145,'detonator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23146,'detoxify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23151,'detract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23152,'deuce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23153,'devalue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23154,'deviancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23155,'deviant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23156,'deviate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23161,'deviation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23162,'deviator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23163,'device');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23164,'devious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23165,'devotedly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23166,'devotee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23211,'devotion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23212,'devourer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23213,'devouring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23214,'devoutly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23215,'dexterity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23216,'dexterous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23221,'diabetes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23222,'diabetic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23223,'diabolic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23224,'diagnoses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23225,'diagnosis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23226,'diagram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23231,'dial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23232,'diameter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23233,'diaper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23234,'diaphragm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23235,'diary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23236,'dice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23241,'dicing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23242,'dictate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23243,'dictation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23244,'dictator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23245,'difficult');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23246,'diffused');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23251,'diffuser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23252,'diffusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23253,'diffusive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23254,'dig');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23255,'dilation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23256,'diligence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23261,'diligent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23262,'dill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23263,'dilute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23264,'dime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23265,'diminish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23266,'dimly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23311,'dimmed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23312,'dimmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23313,'dimness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23314,'dimple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23315,'diner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23316,'dingbat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23321,'dinghy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23322,'dinginess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23323,'dingo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23324,'dingy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23325,'dining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23326,'dinner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23331,'diocese');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23332,'dioxide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23333,'diploma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23334,'dipped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23335,'dipper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23336,'dipping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23341,'directed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23342,'direction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23343,'directive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23344,'directly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23345,'directory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23346,'direness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23351,'dirtiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23352,'disabled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23353,'disagree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23354,'disallow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23355,'disarm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23356,'disarray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23361,'disaster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23362,'disband');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23363,'disbelief');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23364,'disburse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23365,'discard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23366,'discern');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23411,'discharge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23412,'disclose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23413,'discolor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23414,'discount');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23415,'discourse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23416,'discover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23421,'discuss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23422,'disdain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23423,'disengage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23424,'disfigure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23425,'disgrace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23426,'dish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23431,'disinfect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23432,'disjoin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23433,'disk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23434,'dislike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23435,'disliking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23436,'dislocate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23441,'dislodge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23442,'disloyal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23443,'dismantle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23444,'dismay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23445,'dismiss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23446,'dismount');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23451,'disobey');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23452,'disorder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23453,'disown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23454,'disparate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23455,'disparity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23456,'dispatch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23461,'dispense');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23462,'dispersal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23463,'dispersed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23464,'disperser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23465,'displace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23466,'display');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23511,'displease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23512,'disposal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23513,'dispose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23514,'disprove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23515,'dispute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23516,'disregard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23521,'disrupt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23522,'dissuade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23523,'distance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23524,'distant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23525,'distaste');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23526,'distill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23531,'distinct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23532,'distort');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23533,'distract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23534,'distress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23535,'district');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23536,'distrust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23541,'ditch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23542,'ditto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23543,'ditzy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23544,'dividable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23545,'divided');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23546,'dividend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23551,'dividers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23552,'dividing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23553,'divinely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23554,'diving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23555,'divinity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23556,'divisible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23561,'divisibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23562,'division');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23563,'divisive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23564,'divorcee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23565,'dizziness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23566,'dizzy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23611,'doable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23612,'docile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23613,'dock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23614,'doctrine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23615,'document');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23616,'dodge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23621,'dodgy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23622,'doily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23623,'doing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23624,'dole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23625,'dollar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23626,'dollhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23631,'dollop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23632,'dolly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23633,'dolphin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23634,'domain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23635,'domelike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23636,'domestic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23641,'dominion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23642,'dominoes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23643,'donated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23644,'donation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23645,'donator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23646,'donor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23651,'donut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23652,'doodle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23653,'doorbell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23654,'doorframe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23655,'doorknob');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23656,'doorman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23661,'doormat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23662,'doornail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23663,'doorpost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23664,'doorstep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23665,'doorstop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (23666,'doorway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24111,'doozy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24112,'dork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24113,'dormitory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24114,'dorsal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24115,'dosage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24116,'dose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24121,'dotted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24122,'doubling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24123,'douche');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24124,'dove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24125,'down');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24126,'dowry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24131,'doze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24132,'drab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24133,'dragging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24134,'dragonfly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24135,'dragonish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24136,'dragster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24141,'drainable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24142,'drainage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24143,'drained');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24144,'drainer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24145,'drainpipe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24146,'dramatic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24151,'dramatize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24152,'drank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24153,'drapery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24154,'drastic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24155,'draw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24156,'dreaded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24161,'dreadful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24162,'dreadlock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24163,'dreamboat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24164,'dreamily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24165,'dreamland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24166,'dreamless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24211,'dreamlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24212,'dreamt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24213,'dreamy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24214,'drearily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24215,'dreary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24216,'drench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24221,'dress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24222,'drew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24223,'dribble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24224,'dried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24225,'drier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24226,'drift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24231,'driller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24232,'drilling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24233,'drinkable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24234,'drinking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24235,'dripping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24236,'drippy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24241,'drivable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24242,'driven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24243,'driver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24244,'driveway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24245,'driving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24246,'drizzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24251,'drizzly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24252,'drone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24253,'drool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24254,'droop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24255,'drop-down');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24256,'dropbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24261,'dropkick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24262,'droplet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24263,'dropout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24264,'dropper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24265,'drove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24266,'drown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24311,'drowsily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24312,'drudge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24313,'drum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24314,'dry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24315,'dubbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24316,'dubiously');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24321,'duchess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24322,'duckbill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24323,'ducking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24324,'duckling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24325,'ducktail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24326,'ducky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24331,'duct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24332,'dude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24333,'duffel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24334,'dugout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24335,'duh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24336,'duke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24341,'duller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24342,'dullness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24343,'duly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24344,'dumping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24345,'dumpling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24346,'dumpster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24351,'duo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24352,'dupe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24353,'duplex');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24354,'duplicate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24355,'duplicity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24356,'durable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24361,'durably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24362,'duration');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24363,'duress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24364,'during');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24365,'dusk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24366,'dust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24411,'dutiful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24412,'duty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24413,'duvet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24414,'dwarf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24415,'dweeb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24416,'dwelled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24421,'dweller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24422,'dwelling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24423,'dwindle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24424,'dwindling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24425,'dynamic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24426,'dynamite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24431,'dynasty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24432,'dyslexia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24433,'dyslexic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24434,'each');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24435,'eagle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24436,'earache');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24441,'eardrum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24442,'earflap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24443,'earful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24444,'earlobe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24445,'early');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24446,'earmark');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24451,'earmuff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24452,'earphone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24453,'earpiece');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24454,'earplugs');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24455,'earring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24456,'earshot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24461,'earthen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24462,'earthlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24463,'earthling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24464,'earthly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24465,'earthworm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24466,'earthy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24511,'earwig');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24512,'easeful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24513,'easel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24514,'easiest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24515,'easily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24516,'easiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24521,'easing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24522,'eastbound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24523,'eastcoast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24524,'easter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24525,'eastward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24526,'eatable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24531,'eaten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24532,'eatery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24533,'eating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24534,'eats');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24535,'ebay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24536,'ebony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24541,'ebook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24542,'ecard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24543,'eccentric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24544,'echo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24545,'eclair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24546,'eclipse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24551,'ecologist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24552,'ecology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24553,'economic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24554,'economist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24555,'economy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24556,'ecosphere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24561,'ecosystem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24562,'edge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24563,'edginess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24564,'edging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24565,'edgy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24566,'edition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24611,'editor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24612,'educated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24613,'education');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24614,'educator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24615,'eel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24616,'effective');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24621,'effects');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24622,'efficient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24623,'effort');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24624,'eggbeater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24625,'egging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24626,'eggnog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24631,'eggplant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24632,'eggshell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24633,'egomaniac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24634,'egotism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24635,'egotistic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24636,'either');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24641,'eject');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24642,'elaborate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24643,'elastic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24644,'elated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24645,'elbow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24646,'eldercare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24651,'elderly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24652,'eldest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24653,'electable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24654,'election');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24655,'elective');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24656,'elephant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24661,'elevate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24662,'elevating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24663,'elevation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24664,'elevator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24665,'eleven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (24666,'elf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25111,'eligible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25112,'eligibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25113,'eliminate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25114,'elite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25115,'elitism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25116,'elixir');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25121,'elk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25122,'ellipse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25123,'elliptic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25124,'elm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25125,'elongated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25126,'elope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25131,'eloquence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25132,'eloquent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25133,'elsewhere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25134,'elude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25135,'elusive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25136,'elves');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25141,'email');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25142,'embargo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25143,'embark');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25144,'embassy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25145,'embattled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25146,'embellish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25151,'ember');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25152,'embezzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25153,'emblaze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25154,'emblem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25155,'embody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25156,'embolism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25161,'emboss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25162,'embroider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25163,'emcee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25164,'emerald');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25165,'emergency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25166,'emission');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25211,'emit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25212,'emote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25213,'emoticon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25214,'emotion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25215,'empathic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25216,'empathy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25221,'emperor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25222,'emphases');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25223,'emphasis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25224,'emphasize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25225,'emphatic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25226,'empirical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25231,'employed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25232,'employee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25233,'employer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25234,'emporium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25235,'empower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25236,'emptier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25241,'emptiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25242,'empty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25243,'emu');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25244,'enable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25245,'enactment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25246,'enamel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25251,'enchanted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25252,'enchilada');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25253,'encircle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25254,'enclose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25255,'enclosure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25256,'encode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25261,'encore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25262,'encounter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25263,'encourage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25264,'encroach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25265,'encrust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25266,'encrypt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25311,'endanger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25312,'endeared');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25313,'endearing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25314,'ended');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25315,'ending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25316,'endless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25321,'endnote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25322,'endocrine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25323,'endorphin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25324,'endorse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25325,'endowment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25326,'endpoint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25331,'endurable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25332,'endurance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25333,'enduring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25334,'energetic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25335,'energize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25336,'energy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25341,'enforced');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25342,'enforcer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25343,'engaged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25344,'engaging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25345,'engine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25346,'engorge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25351,'engraved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25352,'engraver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25353,'engraving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25354,'engross');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25355,'engulf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25356,'enhance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25361,'enigmatic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25362,'enjoyable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25363,'enjoyably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25364,'enjoyer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25365,'enjoying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25366,'enjoyment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25411,'enlarged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25412,'enlarging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25413,'enlighten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25414,'enlisted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25415,'enquirer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25416,'enrage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25421,'enrich');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25422,'enroll');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25423,'enslave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25424,'ensnare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25425,'ensure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25426,'entail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25431,'entangled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25432,'entering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25433,'entertain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25434,'enticing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25435,'entire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25436,'entitle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25441,'entity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25442,'entomb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25443,'entourage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25444,'entrap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25445,'entree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25446,'entrench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25451,'entrust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25452,'entryway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25453,'entwine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25454,'enunciate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25455,'envelope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25456,'enviable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25461,'enviably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25462,'envious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25463,'envision');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25464,'envoy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25465,'envy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25466,'enzyme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25511,'epic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25512,'epidemic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25513,'epidermal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25514,'epidermis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25515,'epidural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25516,'epilepsy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25521,'epileptic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25522,'epilogue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25523,'epiphany');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25524,'episode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25525,'equal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25526,'equate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25531,'equation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25532,'equator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25533,'equinox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25534,'equipment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25535,'equity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25536,'equivocal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25541,'eradicate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25542,'erasable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25543,'erased');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25544,'eraser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25545,'erasure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25546,'ergonomic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25551,'errand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25552,'errant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25553,'erratic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25554,'error');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25555,'erupt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25556,'escalate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25561,'escalator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25562,'escapable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25563,'escapade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25564,'escapist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25565,'escargot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25566,'eskimo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25611,'esophagus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25612,'espionage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25613,'espresso');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25614,'esquire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25615,'essay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25616,'essence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25621,'essential');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25622,'establish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25623,'estate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25624,'esteemed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25625,'estimate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25626,'estimator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25631,'estranged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25632,'estrogen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25633,'etching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25634,'eternal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25635,'eternity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25636,'ethanol');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25641,'ether');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25642,'ethically');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25643,'ethics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25644,'euphemism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25645,'evacuate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25646,'evacuee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25651,'evade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25652,'evaluate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25653,'evaluator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25654,'evaporate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25655,'evasion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25656,'evasive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25661,'even');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25662,'everglade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25663,'evergreen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25664,'everybody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25665,'everyday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (25666,'everyone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26111,'evict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26112,'evidence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26113,'evident');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26114,'evil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26115,'evoke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26116,'evolution');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26121,'evolve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26122,'exact');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26123,'exalted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26124,'example');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26125,'excavate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26126,'excavator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26131,'exceeding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26132,'exception');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26133,'excess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26134,'exchange');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26135,'excitable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26136,'exciting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26141,'exclaim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26142,'exclude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26143,'excluding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26144,'exclusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26145,'exclusive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26146,'excretion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26151,'excretory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26152,'excursion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26153,'excusable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26154,'excusably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26155,'excuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26156,'exemplary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26161,'exemplify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26162,'exemption');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26163,'exerciser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26164,'exert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26165,'exes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26166,'exfoliate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26211,'exhale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26212,'exhaust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26213,'exhume');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26214,'exile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26215,'existing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26216,'exit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26221,'exodus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26222,'exonerate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26223,'exorcism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26224,'exorcist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26225,'expand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26226,'expanse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26231,'expansion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26232,'expansive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26233,'expectant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26234,'expedited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26235,'expediter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26236,'expel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26241,'expend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26242,'expenses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26243,'expensive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26244,'expert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26245,'expire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26246,'expiring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26251,'explain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26252,'expletive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26253,'explicit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26254,'explode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26255,'exploit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26256,'explore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26261,'exploring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26262,'exponent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26263,'exporter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26264,'exposable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26265,'expose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26266,'exposure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26311,'express');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26312,'expulsion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26313,'exquisite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26314,'extended');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26315,'extending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26316,'extent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26321,'extenuate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26322,'exterior');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26323,'external');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26324,'extinct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26325,'extortion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26326,'extradite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26331,'extras');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26332,'extrovert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26333,'extrude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26334,'extruding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26335,'exuberant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26336,'fable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26341,'fabric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26342,'fabulous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26343,'facebook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26344,'facecloth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26345,'facedown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26346,'faceless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26351,'facelift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26352,'faceplate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26353,'faceted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26354,'facial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26355,'facility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26356,'facing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26361,'facsimile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26362,'faction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26363,'factoid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26364,'factor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26365,'factsheet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26366,'factual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26411,'faculty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26412,'fade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26413,'fading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26414,'failing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26415,'falcon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26416,'fall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26421,'FALSE');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26422,'falsify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26423,'fame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26424,'familiar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26425,'family');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26426,'famine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26431,'famished');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26432,'fanatic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26433,'fancied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26434,'fanciness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26435,'fancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26436,'fanfare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26441,'fang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26442,'fanning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26443,'fantasize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26444,'fantastic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26445,'fantasy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26446,'fascism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26451,'fastball');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26452,'faster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26453,'fasting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26454,'fastness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26455,'faucet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26456,'favorable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26461,'favorably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26462,'favored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26463,'favoring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26464,'favorite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26465,'fax');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26466,'feast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26511,'federal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26512,'fedora');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26513,'feeble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26514,'feed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26515,'feel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26516,'feisty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26521,'feline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26522,'felt-tip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26523,'feminine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26524,'feminism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26525,'feminist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26526,'feminize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26531,'femur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26532,'fence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26533,'fencing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26534,'fender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26535,'ferment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26536,'fernlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26541,'ferocious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26542,'ferocity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26543,'ferret');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26544,'ferris');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26545,'ferry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26546,'fervor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26551,'fester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26552,'festival');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26553,'festive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26554,'festivity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26555,'fetal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26556,'fetch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26561,'fever');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26562,'fiber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26563,'fiction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26564,'fiddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26565,'fiddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26566,'fidelity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26611,'fidgeting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26612,'fidgety');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26613,'fifteen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26614,'fifth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26615,'fiftieth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26616,'fifty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26621,'figment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26622,'figure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26623,'figurine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26624,'filing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26625,'filled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26626,'filler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26631,'filling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26632,'film');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26633,'filter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26634,'filth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26635,'filtrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26636,'finale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26641,'finalist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26642,'finalize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26643,'finally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26644,'finance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26645,'financial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26646,'finch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26651,'fineness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26652,'finer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26653,'finicky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26654,'finished');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26655,'finisher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26656,'finishing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26661,'finite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26662,'finless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26663,'finlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26664,'fiscally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26665,'fit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (26666,'five');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31111,'flaccid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31112,'flagman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31113,'flagpole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31114,'flagship');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31115,'flagstick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31116,'flagstone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31121,'flail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31122,'flakily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31123,'flaky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31124,'flame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31125,'flammable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31126,'flanked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31131,'flanking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31132,'flannels');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31133,'flap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31134,'flaring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31135,'flashback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31136,'flashbulb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31141,'flashcard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31142,'flashily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31143,'flashing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31144,'flashy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31145,'flask');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31146,'flatbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31151,'flatfoot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31152,'flatly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31153,'flatness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31154,'flatten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31155,'flattered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31156,'flatterer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31161,'flattery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31162,'flattop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31163,'flatware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31164,'flatworm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31165,'flavored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31166,'flavorful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31211,'flavoring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31212,'flaxseed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31213,'fled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31214,'fleshed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31215,'fleshy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31216,'flick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31221,'flier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31222,'flight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31223,'flinch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31224,'fling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31225,'flint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31226,'flip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31231,'flirt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31232,'float');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31233,'flock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31234,'flogging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31235,'flop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31236,'floral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31241,'florist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31242,'floss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31243,'flounder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31244,'flyable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31245,'flyaway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31246,'flyer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31251,'flying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31252,'flyover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31253,'flypaper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31254,'foam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31255,'foe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31256,'fog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31261,'foil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31262,'folic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31263,'folk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31264,'follicle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31265,'follow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31266,'fondling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31311,'fondly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31312,'fondness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31313,'fondue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31314,'font');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31315,'food');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31316,'fool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31321,'footage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31322,'football');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31323,'footbath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31324,'footboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31325,'footer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31326,'footgear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31331,'foothill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31332,'foothold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31333,'footing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31334,'footless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31335,'footman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31336,'footnote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31341,'footpad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31342,'footpath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31343,'footprint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31344,'footrest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31345,'footsie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31346,'footsore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31351,'footwear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31352,'footwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31353,'fossil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31354,'foster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31355,'founder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31356,'founding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31361,'fountain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31362,'fox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31363,'foyer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31364,'fraction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31365,'fracture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31366,'fragile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31411,'fragility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31412,'fragment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31413,'fragrance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31414,'fragrant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31415,'frail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31416,'frame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31421,'framing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31422,'frantic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31423,'fraternal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31424,'frayed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31425,'fraying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31426,'frays');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31431,'freckled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31432,'freckles');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31433,'freebase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31434,'freebee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31435,'freebie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31436,'freedom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31441,'freefall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31442,'freehand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31443,'freeing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31444,'freeload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31445,'freely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31446,'freemason');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31451,'freeness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31452,'freestyle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31453,'freeware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31454,'freeway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31455,'freewill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31456,'freezable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31461,'freezing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31462,'freight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31463,'french');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31464,'frenzied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31465,'frenzy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31466,'frequency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31511,'frequent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31512,'fresh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31513,'fretful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31514,'fretted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31515,'friction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31516,'friday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31521,'fridge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31522,'fried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31523,'friend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31524,'frighten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31525,'frightful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31526,'frigidity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31531,'frigidly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31532,'frill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31533,'fringe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31534,'frisbee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31535,'frisk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31536,'fritter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31541,'frivolous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31542,'frolic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31543,'from');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31544,'front');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31545,'frostbite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31546,'frosted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31551,'frostily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31552,'frosting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31553,'frostlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31554,'frosty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31555,'froth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31556,'frown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31561,'frozen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31562,'fructose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31563,'frugality');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31564,'frugally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31565,'fruit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31566,'frustrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31611,'frying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31612,'gab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31613,'gaffe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31614,'gag');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31615,'gainfully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31616,'gaining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31621,'gains');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31622,'gala');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31623,'gallantly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31624,'galleria');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31625,'gallery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31626,'galley');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31631,'gallon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31632,'gallows');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31633,'gallstone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31634,'galore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31635,'galvanize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31636,'gambling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31641,'game');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31642,'gaming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31643,'gamma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31644,'gander');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31645,'gangly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31646,'gangrene');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31651,'gangway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31652,'gap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31653,'garage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31654,'garbage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31655,'garden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31656,'gargle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31661,'garland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31662,'garlic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31663,'garment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31664,'garnet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31665,'garnish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (31666,'garter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32111,'gas');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32112,'gatherer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32113,'gathering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32114,'gating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32115,'gauging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32116,'gauntlet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32121,'gauze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32122,'gave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32123,'gawk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32124,'gazing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32125,'gear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32126,'gecko');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32131,'geek');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32132,'geiger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32133,'gem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32134,'gender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32135,'generic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32136,'generous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32141,'genetics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32142,'genre');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32143,'gentile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32144,'gentleman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32145,'gently');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32146,'gents');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32151,'geography');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32152,'geologic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32153,'geologist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32154,'geology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32155,'geometric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32156,'geometry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32161,'geranium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32162,'gerbil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32163,'geriatric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32164,'germicide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32165,'germinate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32166,'germless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32211,'germproof');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32212,'gestate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32213,'gestation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32214,'gesture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32215,'getaway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32216,'getting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32221,'getup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32222,'giant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32223,'gibberish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32224,'giblet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32225,'giddily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32226,'giddiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32231,'giddy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32232,'gift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32233,'gigabyte');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32234,'gigahertz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32235,'gigantic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32236,'giggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32241,'giggling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32242,'giggly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32243,'gigolo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32244,'gilled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32245,'gills');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32246,'gimmick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32251,'girdle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32252,'giveaway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32253,'given');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32254,'giver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32255,'giving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32256,'gizmo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32261,'gizzard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32262,'glacial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32263,'glacier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32264,'glade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32265,'gladiator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32266,'gladly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32311,'glamorous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32312,'glamour');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32313,'glance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32314,'glancing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32315,'glandular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32316,'glare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32321,'glaring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32322,'glass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32323,'glaucoma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32324,'glazing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32325,'gleaming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32326,'gleeful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32331,'glider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32332,'gliding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32333,'glimmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32334,'glimpse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32335,'glisten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32336,'glitch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32341,'glitter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32342,'glitzy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32343,'gloater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32344,'gloating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32345,'gloomily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32346,'gloomy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32351,'glorified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32352,'glorifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32353,'glorify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32354,'glorious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32355,'glory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32356,'gloss');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32361,'glove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32362,'glowing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32363,'glowworm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32364,'glucose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32365,'glue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32366,'gluten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32411,'glutinous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32412,'glutton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32413,'gnarly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32414,'gnat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32415,'goal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32416,'goatskin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32421,'goes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32422,'goggles');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32423,'going');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32424,'goldfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32425,'goldmine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32426,'goldsmith');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32431,'golf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32432,'goliath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32433,'gonad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32434,'gondola');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32435,'gone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32436,'gong');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32441,'good');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32442,'gooey');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32443,'goofball');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32444,'goofiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32445,'goofy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32446,'google');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32451,'goon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32452,'gopher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32453,'gore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32454,'gorged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32455,'gorgeous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32456,'gory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32461,'gosling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32462,'gossip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32463,'gothic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32464,'gotten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32465,'gout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32466,'gown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32511,'grab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32512,'graceful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32513,'graceless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32514,'gracious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32515,'gradation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32516,'graded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32521,'grader');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32522,'gradient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32523,'grading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32524,'gradually');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32525,'graduate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32526,'graffiti');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32531,'grafted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32532,'grafting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32533,'grain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32534,'granddad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32535,'grandkid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32536,'grandly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32541,'grandma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32542,'grandpa');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32543,'grandson');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32544,'granite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32545,'granny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32546,'granola');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32551,'grant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32552,'granular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32553,'grape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32554,'graph');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32555,'grapple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32556,'grappling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32561,'grasp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32562,'grass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32563,'gratified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32564,'gratify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32565,'grating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32566,'gratitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32611,'gratuity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32612,'gravel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32613,'graveness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32614,'graves');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32615,'graveyard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32616,'gravitate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32621,'gravity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32622,'gravy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32623,'gray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32624,'grazing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32625,'greasily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32626,'greedily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32631,'greedless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32632,'greedy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32633,'green');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32634,'greeter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32635,'greeting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32636,'grew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32641,'greyhound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32642,'grid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32643,'grief');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32644,'grievance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32645,'grieving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32646,'grievous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32651,'grill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32652,'grimace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32653,'grimacing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32654,'grime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32655,'griminess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32656,'grimy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32661,'grinch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32662,'grinning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32663,'grip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32664,'gristle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32665,'grit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (32666,'groggily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33111,'groggy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33112,'groin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33113,'groom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33114,'groove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33115,'grooving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33116,'groovy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33121,'grope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33122,'ground');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33123,'grouped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33124,'grout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33125,'grove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33126,'grower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33131,'growing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33132,'growl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33133,'grub');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33134,'grudge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33135,'grudging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33136,'grueling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33141,'gruffly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33142,'grumble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33143,'grumbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33144,'grumbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33145,'grumpily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33146,'grunge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33151,'grunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33152,'guacamole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33153,'guidable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33154,'guidance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33155,'guide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33156,'guiding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33161,'guileless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33162,'guise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33163,'gulf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33164,'gullible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33165,'gully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33166,'gulp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33211,'gumball');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33212,'gumdrop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33213,'gumminess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33214,'gumming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33215,'gummy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33216,'gurgle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33221,'gurgling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33222,'guru');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33223,'gush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33224,'gusto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33225,'gusty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33226,'gutless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33231,'guts');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33232,'gutter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33233,'guy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33234,'guzzler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33235,'gyration');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33236,'habitable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33241,'habitant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33242,'habitat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33243,'habitual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33244,'hacked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33245,'hacker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33246,'hacking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33251,'hacksaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33252,'had');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33253,'haggler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33254,'haiku');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33255,'half');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33256,'halogen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33261,'halt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33262,'halved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33263,'halves');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33264,'hamburger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33265,'hamlet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33266,'hammock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33311,'hamper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33312,'hamster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33313,'hamstring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33314,'handbag');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33315,'handball');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33316,'handbook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33321,'handbrake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33322,'handcart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33323,'handclap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33324,'handclasp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33325,'handcraft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33326,'handcuff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33331,'handed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33332,'handful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33333,'handgrip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33334,'handgun');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33335,'handheld');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33336,'handiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33341,'handiwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33342,'handlebar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33343,'handled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33344,'handler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33345,'handling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33346,'handmade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33351,'handoff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33352,'handpick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33353,'handprint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33354,'handrail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33355,'handsaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33356,'handset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33361,'handsfree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33362,'handshake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33363,'handstand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33364,'handwash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33365,'handwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33366,'handwoven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33411,'handwrite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33412,'handyman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33413,'hangnail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33414,'hangout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33415,'hangover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33416,'hangup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33421,'hankering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33422,'hankie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33423,'hanky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33424,'haphazard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33425,'happening');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33426,'happier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33431,'happiest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33432,'happily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33433,'happiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33434,'happy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33435,'harbor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33436,'hardcopy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33441,'hardcore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33442,'hardcover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33443,'harddisk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33444,'hardened');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33445,'hardener');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33446,'hardening');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33451,'hardhat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33452,'hardhead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33453,'hardiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33454,'hardly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33455,'hardness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33456,'hardship');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33461,'hardware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33462,'hardwired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33463,'hardwood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33464,'hardy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33465,'harmful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33466,'harmless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33511,'harmonica');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33512,'harmonics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33513,'harmonize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33514,'harmony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33515,'harness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33516,'harpist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33521,'harsh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33522,'harvest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33523,'hash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33524,'hassle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33525,'haste');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33526,'hastily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33531,'hastiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33532,'hasty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33533,'hatbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33534,'hatchback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33535,'hatchery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33536,'hatchet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33541,'hatching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33542,'hatchling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33543,'hate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33544,'hatless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33545,'hatred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33546,'haunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33551,'haven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33552,'hazard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33553,'hazelnut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33554,'hazily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33555,'haziness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33556,'hazing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33561,'hazy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33562,'headache');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33563,'headband');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33564,'headboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33565,'headcount');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33566,'headdress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33611,'headed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33612,'header');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33613,'headfirst');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33614,'headgear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33615,'heading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33616,'headlamp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33621,'headless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33622,'headlock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33623,'headphone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33624,'headpiece');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33625,'headrest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33626,'headroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33631,'headscarf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33632,'headset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33633,'headsman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33634,'headstand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33635,'headstone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33636,'headway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33641,'headwear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33642,'heap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33643,'heat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33644,'heave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33645,'heavily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33646,'heaviness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33651,'heaving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33652,'hedge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33653,'hedging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33654,'heftiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33655,'hefty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33656,'helium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33661,'helmet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33662,'helper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33663,'helpful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33664,'helping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33665,'helpless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (33666,'helpline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34111,'hemlock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34112,'hemstitch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34113,'hence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34114,'henchman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34115,'henna');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34116,'herald');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34121,'herbal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34122,'herbicide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34123,'herbs');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34124,'heritage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34125,'hermit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34126,'heroics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34131,'heroism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34132,'herring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34133,'herself');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34134,'hertz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34135,'hesitancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34136,'hesitant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34141,'hesitate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34142,'hexagon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34143,'hexagram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34144,'hubcap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34145,'huddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34146,'huddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34151,'huff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34152,'hug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34153,'hula');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34154,'hulk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34155,'hull');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34156,'human');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34161,'humble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34162,'humbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34163,'humbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34164,'humid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34165,'humiliate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34166,'humility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34211,'humming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34212,'hummus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34213,'humongous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34214,'humorist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34215,'humorless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34216,'humorous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34221,'humpback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34222,'humped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34223,'humvee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34224,'hunchback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34225,'hundredth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34226,'hunger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34231,'hungrily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34232,'hungry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34233,'hunk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34234,'hunter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34235,'hunting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34236,'huntress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34241,'huntsman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34242,'hurdle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34243,'hurled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34244,'hurler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34245,'hurling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34246,'hurray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34251,'hurricane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34252,'hurried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34253,'hurry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34254,'hurt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34255,'husband');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34256,'hush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34261,'husked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34262,'huskiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34263,'hut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34264,'hybrid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34265,'hydrant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34266,'hydrated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34311,'hydration');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34312,'hydrogen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34313,'hydroxide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34314,'hyperlink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34315,'hypertext');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34316,'hyphen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34321,'hypnoses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34322,'hypnosis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34323,'hypnotic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34324,'hypnotism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34325,'hypnotist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34326,'hypnotize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34331,'hypocrisy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34332,'hypocrite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34333,'ibuprofen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34334,'ice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34335,'iciness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34336,'icing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34341,'icky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34342,'icon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34343,'icy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34344,'idealism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34345,'idealist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34346,'idealize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34351,'ideally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34352,'idealness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34353,'identical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34354,'identify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34355,'identity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34356,'ideology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34361,'idiocy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34362,'idiom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34363,'idly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34364,'igloo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34365,'ignition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34366,'ignore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34411,'iguana');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34412,'illicitly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34413,'illusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34414,'illusive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34415,'image');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34416,'imaginary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34421,'imagines');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34422,'imaging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34423,'imbecile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34424,'imitate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34425,'imitation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34426,'immature');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34431,'immerse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34432,'immersion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34433,'imminent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34434,'immobile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34435,'immodest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34436,'immorally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34441,'immortal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34442,'immovable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34443,'immovably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34444,'immunity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34445,'immunize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34446,'impaired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34451,'impale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34452,'impart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34453,'impatient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34454,'impeach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34455,'impeding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34456,'impending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34461,'imperfect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34462,'imperial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34463,'impish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34464,'implant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34465,'implement');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34466,'implicate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34511,'implicit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34512,'implode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34513,'implosion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34514,'implosive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34515,'imply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34516,'impolite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34521,'important');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34522,'importer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34523,'impose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34524,'imposing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34525,'impotence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34526,'impotency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34531,'impotent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34532,'impound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34533,'imprecise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34534,'imprint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34535,'imprison');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34536,'impromptu');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34541,'improper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34542,'improve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34543,'improving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34544,'improvise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34545,'imprudent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34546,'impulse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34551,'impulsive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34552,'impure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34553,'impurity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34554,'iodine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34555,'iodize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34556,'ion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34561,'ipad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34562,'iphone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34563,'ipod');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34564,'irate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34565,'irk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34566,'iron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34611,'irregular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34612,'irrigate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34613,'irritable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34614,'irritably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34615,'irritant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34616,'irritate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34621,'islamic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34622,'islamist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34623,'isolated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34624,'isolating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34625,'isolation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34626,'isotope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34631,'issue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34632,'issuing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34633,'italicize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34634,'italics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34635,'item');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34636,'itinerary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34641,'itunes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34642,'ivory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34643,'ivy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34644,'jab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34645,'jackal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34646,'jacket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34651,'jackknife');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34652,'jackpot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34653,'jailbird');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34654,'jailbreak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34655,'jailer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34656,'jailhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34661,'jalapeno');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34662,'jam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34663,'janitor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34664,'january');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34665,'jargon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (34666,'jarring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35111,'jasmine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35112,'jaundice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35113,'jaunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35114,'java');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35115,'jawed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35116,'jawless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35121,'jawline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35122,'jaws');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35123,'jaybird');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35124,'jaywalker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35125,'jazz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35126,'jeep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35131,'jeeringly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35132,'jellied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35133,'jelly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35134,'jersey');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35135,'jester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35136,'jet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35141,'jiffy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35142,'jigsaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35143,'jimmy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35144,'jingle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35145,'jingling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35146,'jinx');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35151,'jitters');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35152,'jittery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35153,'job');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35154,'jockey');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35155,'jockstrap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35156,'jogger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35161,'jogging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35162,'john');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35163,'joining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35164,'jokester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35165,'jokingly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35166,'jolliness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35211,'jolly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35212,'jolt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35213,'jot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35214,'jovial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35215,'joyfully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35216,'joylessly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35221,'joyous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35222,'joyride');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35223,'joystick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35224,'jubilance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35225,'jubilant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35226,'judge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35231,'judgingly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35232,'judicial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35233,'judiciary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35234,'judo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35235,'juggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35236,'juggling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35241,'jugular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35242,'juice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35243,'juiciness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35244,'juicy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35245,'jujitsu');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35246,'jukebox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35251,'july');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35252,'jumble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35253,'jumbo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35254,'jump');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35255,'junction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35256,'juncture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35261,'june');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35262,'junior');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35263,'juniper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35264,'junkie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35265,'junkman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35266,'junkyard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35311,'jurist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35312,'juror');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35313,'jury');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35314,'justice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35315,'justifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35316,'justify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35321,'justly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35322,'justness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35323,'juvenile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35324,'kabob');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35325,'kangaroo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35326,'karaoke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35331,'karate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35332,'karma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35333,'kebab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35334,'keenly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35335,'keenness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35336,'keep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35341,'keg');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35342,'kelp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35343,'kennel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35344,'kept');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35345,'kerchief');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35346,'kerosene');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35351,'kettle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35352,'kick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35353,'kiln');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35354,'kilobyte');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35355,'kilogram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35356,'kilometer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35361,'kilowatt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35362,'kilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35363,'kimono');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35364,'kindle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35365,'kindling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35366,'kindly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35411,'kindness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35412,'kindred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35413,'kinetic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35414,'kinfolk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35415,'king');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35416,'kinship');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35421,'kinsman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35422,'kinswoman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35423,'kissable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35424,'kisser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35425,'kissing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35426,'kitchen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35431,'kite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35432,'kitten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35433,'kitty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35434,'kiwi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35435,'kleenex');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35436,'knapsack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35441,'knee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35442,'knelt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35443,'knickers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35444,'knoll');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35445,'koala');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35446,'kooky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35451,'kosher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35452,'krypton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35453,'kudos');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35454,'kung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35455,'labored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35456,'laborer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35461,'laboring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35462,'laborious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35463,'labrador');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35464,'ladder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35465,'ladies');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35466,'ladle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35511,'ladybug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35512,'ladylike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35513,'lagged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35514,'lagging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35515,'lagoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35516,'lair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35521,'lake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35522,'lance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35523,'landed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35524,'landfall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35525,'landfill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35526,'landing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35531,'landlady');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35532,'landless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35533,'landline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35534,'landlord');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35535,'landmark');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35536,'landmass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35541,'landmine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35542,'landowner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35543,'landscape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35544,'landside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35545,'landslide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35546,'language');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35551,'lankiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35552,'lanky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35553,'lantern');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35554,'lapdog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35555,'lapel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35556,'lapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35561,'lapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35562,'laptop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35563,'lard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35564,'large');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35565,'lark');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35566,'lash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35611,'lasso');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35612,'last');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35613,'latch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35614,'late');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35615,'lather');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35616,'latitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35621,'latrine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35622,'latter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35623,'latticed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35624,'launch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35625,'launder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35626,'laundry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35631,'laurel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35632,'lavender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35633,'lavish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35634,'laxative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35635,'lazily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35636,'laziness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35641,'lazy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35642,'lecturer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35643,'left');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35644,'legacy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35645,'legal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35646,'legend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35651,'legged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35652,'leggings');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35653,'legible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35654,'legibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35655,'legislate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35656,'lego');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35661,'legroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35662,'legume');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35663,'legwarmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35664,'legwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35665,'lemon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (35666,'lend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36111,'length');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36112,'lens');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36113,'lent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36114,'leotard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36115,'lesser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36116,'letdown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36121,'lethargic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36122,'lethargy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36123,'letter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36124,'lettuce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36125,'level');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36126,'leverage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36131,'levers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36132,'levitate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36133,'levitator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36134,'liability');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36135,'liable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36136,'liberty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36141,'librarian');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36142,'library');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36143,'licking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36144,'licorice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36145,'lid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36146,'life');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36151,'lifter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36152,'lifting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36153,'liftoff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36154,'ligament');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36155,'likely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36156,'likeness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36161,'likewise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36162,'liking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36163,'lilac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36164,'lilly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36165,'lily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36166,'limb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36211,'limeade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36212,'limelight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36213,'limes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36214,'limit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36215,'limping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36216,'limpness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36221,'line');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36222,'lingo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36223,'linguini');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36224,'linguist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36225,'lining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36226,'linked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36231,'linoleum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36232,'linseed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36233,'lint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36234,'lion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36235,'lip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36236,'liquefy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36241,'liqueur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36242,'liquid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36243,'lisp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36244,'list');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36245,'litigate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36246,'litigator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36251,'litmus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36252,'litter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36253,'little');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36254,'livable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36255,'lived');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36256,'lively');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36261,'liver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36262,'livestock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36263,'lividly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36264,'living');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36265,'lizard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36266,'lubricant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36311,'lubricate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36312,'lucid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36313,'luckily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36314,'luckiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36315,'luckless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36316,'lucrative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36321,'ludicrous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36322,'lugged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36323,'lukewarm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36324,'lullaby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36325,'lumber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36326,'luminance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36331,'luminous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36332,'lumpiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36333,'lumping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36334,'lumpish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36335,'lunacy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36336,'lunar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36341,'lunchbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36342,'luncheon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36343,'lunchroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36344,'lunchtime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36345,'lung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36346,'lurch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36351,'lure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36352,'luridness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36353,'lurk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36354,'lushly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36355,'lushness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36356,'luster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36361,'lustfully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36362,'lustily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36363,'lustiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36364,'lustrous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36365,'lusty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36366,'luxurious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36411,'luxury');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36412,'lying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36413,'lyrically');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36414,'lyricism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36415,'lyricist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36416,'lyrics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36421,'macarena');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36422,'macaroni');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36423,'macaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36424,'mace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36425,'machine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36426,'machinist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36431,'magazine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36432,'magenta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36433,'maggot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36434,'magical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36435,'magician');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36436,'magma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36441,'magnesium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36442,'magnetic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36443,'magnetism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36444,'magnetize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36445,'magnifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36446,'magnify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36451,'magnitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36452,'magnolia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36453,'mahogany');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36454,'maimed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36455,'majestic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36456,'majesty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36461,'majorette');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36462,'majority');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36463,'makeover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36464,'maker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36465,'makeshift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36466,'making');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36511,'malformed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36512,'malt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36513,'mama');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36514,'mammal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36515,'mammary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36516,'mammogram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36521,'manager');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36522,'managing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36523,'manatee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36524,'mandarin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36525,'mandate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36526,'mandatory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36531,'mandolin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36532,'manger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36533,'mangle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36534,'mango');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36535,'mangy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36536,'manhandle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36541,'manhole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36542,'manhood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36543,'manhunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36544,'manicotti');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36545,'manicure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36546,'manifesto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36551,'manila');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36552,'mankind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36553,'manlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36554,'manliness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36555,'manly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36556,'manmade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36561,'manned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36562,'mannish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36563,'manor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36564,'manpower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36565,'mantis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36566,'mantra');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36611,'manual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36612,'many');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36613,'map');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36614,'marathon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36615,'marauding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36616,'marbled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36621,'marbles');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36622,'marbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36623,'march');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36624,'mardi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36625,'margarine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36626,'margarita');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36631,'margin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36632,'marigold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36633,'marina');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36634,'marine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36635,'marital');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36636,'maritime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36641,'marlin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36642,'marmalade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36643,'maroon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36644,'married');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36645,'marrow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36646,'marry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36651,'marshland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36652,'marshy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36653,'marsupial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36654,'marvelous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36655,'marxism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36656,'mascot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36661,'masculine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36662,'mashed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36663,'mashing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36664,'massager');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36665,'masses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (36666,'massive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41111,'mastiff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41112,'matador');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41113,'matchbook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41114,'matchbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41115,'matcher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41116,'matching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41121,'matchless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41122,'material');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41123,'maternal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41124,'maternity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41125,'math');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41126,'mating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41131,'matriarch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41132,'matrimony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41133,'matrix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41134,'matron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41135,'matted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41136,'matter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41141,'maturely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41142,'maturing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41143,'maturity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41144,'mauve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41145,'maverick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41146,'maximize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41151,'maximum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41152,'maybe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41153,'mayday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41154,'mayflower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41155,'moaner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41156,'moaning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41161,'mobile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41162,'mobility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41163,'mobilize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41164,'mobster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41165,'mocha');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41166,'mocker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41211,'mockup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41212,'modified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41213,'modify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41214,'modular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41215,'modulator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41216,'module');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41221,'moisten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41222,'moistness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41223,'moisture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41224,'molar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41225,'molasses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41226,'mold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41231,'molecular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41232,'molecule');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41233,'molehill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41234,'mollusk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41235,'mom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41236,'monastery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41241,'monday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41242,'monetary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41243,'monetize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41244,'moneybags');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41245,'moneyless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41246,'moneywise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41251,'mongoose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41252,'mongrel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41253,'monitor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41254,'monkhood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41255,'monogamy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41256,'monogram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41261,'monologue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41262,'monopoly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41263,'monorail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41264,'monotone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41265,'monotype');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41266,'monoxide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41311,'monsieur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41312,'monsoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41313,'monstrous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41314,'monthly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41315,'monument');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41316,'moocher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41321,'moodiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41322,'moody');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41323,'mooing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41324,'moonbeam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41325,'mooned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41326,'moonlight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41331,'moonlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41332,'moonlit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41333,'moonrise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41334,'moonscape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41335,'moonshine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41336,'moonstone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41341,'moonwalk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41342,'mop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41343,'morale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41344,'morality');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41345,'morally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41346,'morbidity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41351,'morbidly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41352,'morphine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41353,'morphing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41354,'morse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41355,'mortality');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41356,'mortally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41361,'mortician');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41362,'mortified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41363,'mortify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41364,'mortuary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41365,'mosaic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41366,'mossy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41411,'most');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41412,'mothball');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41413,'mothproof');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41414,'motion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41415,'motivate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41416,'motivator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41421,'motive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41422,'motocross');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41423,'motor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41424,'motto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41425,'mountable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41426,'mountain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41431,'mounted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41432,'mounting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41433,'mourner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41434,'mournful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41435,'mouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41436,'mousiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41441,'moustache');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41442,'mousy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41443,'mouth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41444,'movable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41445,'move');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41446,'movie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41451,'moving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41452,'mower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41453,'mowing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41454,'much');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41455,'muck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41456,'mud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41461,'mug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41462,'mulberry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41463,'mulch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41464,'mule');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41465,'mulled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41466,'mullets');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41511,'multiple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41512,'multiply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41513,'multitask');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41514,'multitude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41515,'mumble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41516,'mumbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41521,'mumbo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41522,'mummified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41523,'mummify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41524,'mummy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41525,'mumps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41526,'munchkin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41531,'mundane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41532,'municipal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41533,'muppet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41534,'mural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41535,'murkiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41536,'murky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41541,'murmuring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41542,'muscular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41543,'museum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41544,'mushily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41545,'mushiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41546,'mushroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41551,'mushy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41552,'music');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41553,'musket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41554,'muskiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41555,'musky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41556,'mustang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41561,'mustard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41562,'muster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41563,'mustiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41564,'musty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41565,'mutable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41566,'mutate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41611,'mutation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41612,'mute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41613,'mutilated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41614,'mutilator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41615,'mutiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41616,'mutt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41621,'mutual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41622,'muzzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41623,'myself');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41624,'myspace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41625,'mystified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41626,'mystify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41631,'myth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41632,'nacho');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41633,'nag');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41634,'nail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41635,'name');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41636,'naming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41641,'nanny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41642,'nanometer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41643,'nape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41644,'napkin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41645,'napped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41646,'napping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41651,'nappy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41652,'narrow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41653,'nastily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41654,'nastiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41655,'national');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41656,'native');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41661,'nativity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41662,'natural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41663,'nature');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41664,'naturist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41665,'nautical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (41666,'navigate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42111,'navigator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42112,'navy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42113,'nearby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42114,'nearest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42115,'nearly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42116,'nearness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42121,'neatly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42122,'neatness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42123,'nebula');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42124,'nebulizer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42125,'nectar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42126,'negate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42131,'negation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42132,'negative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42133,'neglector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42134,'negligee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42135,'negligent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42136,'negotiate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42141,'nemeses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42142,'nemesis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42143,'neon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42144,'nephew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42145,'nerd');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42146,'nervous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42151,'nervy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42152,'nest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42153,'net');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42154,'neurology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42155,'neuron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42156,'neurosis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42161,'neurotic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42162,'neuter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42163,'neutron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42164,'never');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42165,'next');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42166,'nibble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42211,'nickname');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42212,'nicotine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42213,'niece');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42214,'nifty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42215,'nimble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42216,'nimbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42221,'nineteen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42222,'ninetieth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42223,'ninja');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42224,'nintendo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42225,'ninth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42226,'nuclear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42231,'nuclei');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42232,'nucleus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42233,'nugget');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42234,'nullify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42235,'number');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42236,'numbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42241,'numbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42242,'numbness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42243,'numeral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42244,'numerate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42245,'numerator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42246,'numeric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42251,'numerous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42252,'nuptials');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42253,'nursery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42254,'nursing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42255,'nurture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42256,'nutcase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42261,'nutlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42262,'nutmeg');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42263,'nutrient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42264,'nutshell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42265,'nuttiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42266,'nutty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42311,'nuzzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42312,'nylon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42313,'oaf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42314,'oak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42315,'oasis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42316,'oat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42321,'obedience');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42322,'obedient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42323,'obituary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42324,'object');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42325,'obligate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42326,'obliged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42331,'oblivion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42332,'oblivious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42333,'oblong');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42334,'obnoxious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42335,'oboe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42336,'obscure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42341,'obscurity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42342,'observant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42343,'observer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42344,'observing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42345,'obsessed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42346,'obsession');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42351,'obsessive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42352,'obsolete');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42353,'obstacle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42354,'obstinate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42355,'obstruct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42356,'obtain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42361,'obtrusive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42362,'obtuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42363,'obvious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42364,'occultist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42365,'occupancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42366,'occupant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42411,'occupier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42412,'occupy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42413,'ocean');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42414,'ocelot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42415,'octagon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42416,'octane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42421,'october');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42422,'octopus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42423,'ogle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42424,'oil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42425,'oink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42426,'ointment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42431,'okay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42432,'old');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42433,'olive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42434,'olympics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42435,'omega');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42436,'omen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42441,'ominous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42442,'omission');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42443,'omit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42444,'omnivore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42445,'onboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42446,'oncoming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42451,'ongoing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42452,'onion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42453,'online');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42454,'onlooker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42455,'only');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42456,'onscreen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42461,'onset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42462,'onshore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42463,'onslaught');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42464,'onstage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42465,'onto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42466,'onward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42511,'onyx');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42512,'oops');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42513,'ooze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42514,'oozy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42515,'opacity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42516,'opal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42521,'open');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42522,'operable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42523,'operate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42524,'operating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42525,'operation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42526,'operative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42531,'operator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42532,'opium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42533,'opossum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42534,'opponent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42535,'oppose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42536,'opposing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42541,'opposite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42542,'oppressed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42543,'oppressor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42544,'opt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42545,'opulently');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42546,'osmosis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42551,'other');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42552,'otter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42553,'ouch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42554,'ought');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42555,'ounce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42556,'outage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42561,'outback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42562,'outbid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42563,'outboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42564,'outbound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42565,'outbreak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42566,'outburst');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42611,'outcast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42612,'outclass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42613,'outcome');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42614,'outdated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42615,'outdoors');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42616,'outer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42621,'outfield');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42622,'outfit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42623,'outflank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42624,'outgoing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42625,'outgrow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42626,'outhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42631,'outing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42632,'outlast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42633,'outlet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42634,'outline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42635,'outlook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42636,'outlying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42641,'outmatch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42642,'outmost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42643,'outnumber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42644,'outplayed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42645,'outpost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42646,'outpour');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42651,'output');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42652,'outrage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42653,'outrank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42654,'outreach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42655,'outright');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42656,'outscore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42661,'outsell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42662,'outshine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42663,'outshoot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42664,'outsider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42665,'outskirts');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (42666,'outsmart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43111,'outsource');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43112,'outspoken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43113,'outtakes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43114,'outthink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43115,'outward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43116,'outweigh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43121,'outwit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43122,'oval');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43123,'ovary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43124,'oven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43125,'overact');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43126,'overall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43131,'overarch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43132,'overbid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43133,'overbill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43134,'overbite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43135,'overblown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43136,'overboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43141,'overbook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43142,'overbuilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43143,'overcast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43144,'overcoat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43145,'overcome');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43146,'overcook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43151,'overcrowd');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43152,'overdraft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43153,'overdrawn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43154,'overdress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43155,'overdrive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43156,'overdue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43161,'overeager');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43162,'overeater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43163,'overexert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43164,'overfed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43165,'overfeed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43166,'overfill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43211,'overflow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43212,'overfull');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43213,'overgrown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43214,'overhand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43215,'overhang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43216,'overhaul');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43221,'overhead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43222,'overhear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43223,'overheat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43224,'overhung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43225,'overjoyed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43226,'overkill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43231,'overlabor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43232,'overlaid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43233,'overlap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43234,'overlay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43235,'overload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43236,'overlook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43241,'overlord');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43242,'overlying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43243,'overnight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43244,'overpass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43245,'overpay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43246,'overplant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43251,'overplay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43252,'overpower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43253,'overprice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43254,'overrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43255,'overreach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43256,'overreact');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43261,'override');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43262,'overripe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43263,'overrule');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43264,'overrun');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43265,'overshoot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43266,'overshot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43311,'oversight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43312,'oversized');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43313,'oversleep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43314,'oversold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43315,'overspend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43316,'overstate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43321,'overstay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43322,'overstep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43323,'overstock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43324,'overstuff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43325,'oversweet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43326,'overtake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43331,'overthrow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43332,'overtime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43333,'overtly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43334,'overtone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43335,'overture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43336,'overturn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43341,'overuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43342,'overvalue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43343,'overview');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43344,'overwrite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43345,'owl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43346,'oxford');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43351,'oxidant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43352,'oxidation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43353,'oxidize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43354,'oxidizing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43355,'oxygen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43356,'oxymoron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43361,'oyster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43362,'ozone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43363,'paced');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43364,'pacemaker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43365,'pacific');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43366,'pacifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43411,'pacifism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43412,'pacifist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43413,'pacify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43414,'padded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43415,'padding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43416,'paddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43421,'paddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43422,'padlock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43423,'pagan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43424,'pager');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43425,'paging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43426,'pajamas');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43431,'palace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43432,'palatable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43433,'palm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43434,'palpable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43435,'palpitate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43436,'paltry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43441,'pampered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43442,'pamperer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43443,'pampers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43444,'pamphlet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43445,'panama');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43446,'pancake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43451,'pancreas');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43452,'panda');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43453,'pandemic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43454,'pang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43455,'panhandle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43456,'panic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43461,'panning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43462,'panorama');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43463,'panoramic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43464,'panther');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43465,'pantomime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43466,'pantry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43511,'pants');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43512,'pantyhose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43513,'paparazzi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43514,'papaya');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43515,'paper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43516,'paprika');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43521,'papyrus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43522,'parabola');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43523,'parachute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43524,'parade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43525,'paradox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43526,'paragraph');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43531,'parakeet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43532,'paralegal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43533,'paralyses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43534,'paralysis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43535,'paralyze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43536,'paramedic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43541,'parameter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43542,'paramount');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43543,'parasail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43544,'parasite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43545,'parasitic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43546,'parcel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43551,'parched');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43552,'parchment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43553,'pardon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43554,'parish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43555,'parka');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43556,'parking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43561,'parkway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43562,'parlor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43563,'parmesan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43564,'parole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43565,'parrot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43566,'parsley');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43611,'parsnip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43612,'partake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43613,'parted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43614,'parting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43615,'partition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43616,'partly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43621,'partner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43622,'partridge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43623,'party');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43624,'passable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43625,'passably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43626,'passage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43631,'passcode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43632,'passenger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43633,'passerby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43634,'passing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43635,'passion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43636,'passive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43641,'passivism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43642,'passover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43643,'passport');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43644,'password');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43645,'pasta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43646,'pasted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43651,'pastel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43652,'pastime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43653,'pastor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43654,'pastrami');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43655,'pasture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43656,'pasty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43661,'patchwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43662,'patchy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43663,'paternal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43664,'paternity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43665,'path');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (43666,'patience');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44111,'patient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44112,'patio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44113,'patriarch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44114,'patriot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44115,'patrol');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44116,'patronage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44121,'patronize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44122,'pauper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44123,'pavement');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44124,'paver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44125,'pavestone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44126,'pavilion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44131,'paving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44132,'pawing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44133,'payable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44134,'payback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44135,'paycheck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44136,'payday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44141,'payee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44142,'payer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44143,'paying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44144,'payment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44145,'payphone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44146,'payroll');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44151,'pebble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44152,'pebbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44153,'pecan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44154,'pectin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44155,'peculiar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44156,'peddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44161,'pediatric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44162,'pedicure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44163,'pedigree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44164,'pedometer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44165,'pegboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44166,'pelican');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44211,'pellet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44212,'pelt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44213,'pelvis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44214,'penalize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44215,'penalty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44216,'pencil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44221,'pendant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44222,'pending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44223,'penholder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44224,'penknife');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44225,'pennant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44226,'penniless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44231,'penny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44232,'penpal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44233,'pension');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44234,'pentagon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44235,'pentagram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44236,'pep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44241,'perceive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44242,'percent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44243,'perch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44244,'percolate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44245,'perennial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44246,'perfected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44251,'perfectly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44252,'perfume');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44253,'periscope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44254,'perish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44255,'perjurer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44256,'perjury');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44261,'perkiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44262,'perky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44263,'perm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44264,'peroxide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44265,'perpetual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44266,'perplexed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44311,'persecute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44312,'persevere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44313,'persuaded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44314,'persuader');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44315,'pesky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44316,'peso');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44321,'pessimism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44322,'pessimist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44323,'pester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44324,'pesticide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44325,'petal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44326,'petite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44331,'petition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44332,'petri');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44333,'petroleum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44334,'petted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44335,'petticoat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44336,'pettiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44341,'petty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44342,'petunia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44343,'phantom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44344,'phobia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44345,'phoenix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44346,'phonebook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44351,'phoney');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44352,'phonics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44353,'phoniness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44354,'phony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44355,'phosphate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44356,'photo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44361,'phrase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44362,'phrasing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44363,'placard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44364,'placate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44365,'placidly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44366,'plank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44411,'planner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44412,'plant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44413,'plasma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44414,'plaster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44415,'plastic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44416,'plated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44421,'platform');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44422,'plating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44423,'platinum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44424,'platonic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44425,'platter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44426,'platypus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44431,'plausible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44432,'plausibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44433,'playable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44434,'playback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44435,'player');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44436,'playful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44441,'playgroup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44442,'playhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44443,'playing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44444,'playlist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44445,'playmaker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44446,'playmate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44451,'playoff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44452,'playpen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44453,'playroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44454,'playset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44455,'plaything');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44456,'playtime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44461,'plaza');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44462,'pleading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44463,'pleat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44464,'pledge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44465,'plentiful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44466,'plenty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44511,'plethora');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44512,'plexiglas');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44513,'pliable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44514,'plod');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44515,'plop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44516,'plot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44521,'plow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44522,'ploy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44523,'pluck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44524,'plug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44525,'plunder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44526,'plunging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44531,'plural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44532,'plus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44533,'plutonium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44534,'plywood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44535,'poach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44536,'pod');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44541,'poem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44542,'poet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44543,'pogo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44544,'pointed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44545,'pointer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44546,'pointing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44551,'pointless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44552,'pointy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44553,'poise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44554,'poison');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44555,'poker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44556,'poking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44561,'polar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44562,'police');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44563,'policy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44564,'polio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44565,'polish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44566,'politely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44611,'polka');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44612,'polo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44613,'polyester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44614,'polygon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44615,'polygraph');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44616,'polymer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44621,'poncho');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44622,'pond');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44623,'pony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44624,'popcorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44625,'pope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44626,'poplar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44631,'popper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44632,'poppy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44633,'popsicle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44634,'populace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44635,'popular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44636,'populate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44641,'porcupine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44642,'pork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44643,'porous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44644,'porridge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44645,'portable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44646,'portal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44651,'portfolio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44652,'porthole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44653,'portion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44654,'portly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44655,'portside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44656,'poser');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44661,'posh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44662,'posing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44663,'possible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44664,'possibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44665,'possum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (44666,'postage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45111,'postal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45112,'postbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45113,'postcard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45114,'posted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45115,'poster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45116,'posting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45121,'postnasal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45122,'posture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45123,'postwar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45124,'pouch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45125,'pounce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45126,'pouncing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45131,'pound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45132,'pouring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45133,'pout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45134,'powdered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45135,'powdering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45136,'powdery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45141,'power');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45142,'powwow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45143,'pox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45144,'praising');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45145,'prance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45146,'prancing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45151,'pranker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45152,'prankish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45153,'prankster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45154,'prayer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45155,'praying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45156,'preacher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45161,'preaching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45162,'preachy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45163,'preamble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45164,'precinct');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45165,'precise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45166,'precision');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45211,'precook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45212,'precut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45213,'predator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45214,'predefine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45215,'predict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45216,'preface');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45221,'prefix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45222,'preflight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45223,'preformed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45224,'pregame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45225,'pregnancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45226,'pregnant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45231,'preheated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45232,'prelaunch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45233,'prelaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45234,'prelude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45235,'premiere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45236,'premises');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45241,'premium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45242,'prenatal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45243,'preoccupy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45244,'preorder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45245,'prepaid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45246,'prepay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45251,'preplan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45252,'preppy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45253,'preschool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45254,'prescribe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45255,'preseason');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45256,'preset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45261,'preshow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45262,'president');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45263,'presoak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45264,'press');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45265,'presume');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45266,'presuming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45311,'preteen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45312,'pretended');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45313,'pretender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45314,'pretense');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45315,'pretext');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45316,'pretty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45321,'pretzel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45322,'prevail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45323,'prevalent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45324,'prevent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45325,'preview');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45326,'previous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45331,'prewar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45332,'prewashed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45333,'prideful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45334,'pried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45335,'primal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45336,'primarily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45341,'primary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45342,'primate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45343,'primer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45344,'primp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45345,'princess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45346,'print');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45351,'prior');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45352,'prism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45353,'prison');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45354,'prissy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45355,'pristine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45356,'privacy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45361,'private');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45362,'privatize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45363,'prize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45364,'proactive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45365,'probable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45366,'probably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45411,'probation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45412,'probe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45413,'probing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45414,'probiotic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45415,'problem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45416,'procedure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45421,'process');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45422,'proclaim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45423,'procreate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45424,'procurer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45425,'prodigal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45426,'prodigy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45431,'produce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45432,'product');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45433,'profane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45434,'profanity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45435,'professed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45436,'professor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45441,'profile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45442,'profound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45443,'profusely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45444,'progeny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45445,'prognosis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45446,'program');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45451,'progress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45452,'projector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45453,'prologue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45454,'prolonged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45455,'promenade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45456,'prominent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45461,'promoter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45462,'promotion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45463,'prompter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45464,'promptly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45465,'prone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45466,'prong');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45511,'pronounce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45512,'pronto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45513,'proofing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45514,'proofread');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45515,'proofs');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45516,'propeller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45521,'properly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45522,'property');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45523,'proponent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45524,'proposal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45525,'propose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45526,'props');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45531,'prorate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45532,'protector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45533,'protegee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45534,'proton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45535,'prototype');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45536,'protozoan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45541,'protract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45542,'protrude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45543,'proud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45544,'provable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45545,'proved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45546,'proven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45551,'provided');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45552,'provider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45553,'providing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45554,'province');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45555,'proving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45556,'provoke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45561,'provoking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45562,'provolone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45563,'prowess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45564,'prowler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45565,'prowling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45566,'proximity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45611,'proxy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45612,'prozac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45613,'prude');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45614,'prudishly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45615,'prune');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45616,'pruning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45621,'pry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45622,'psychic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45623,'public');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45624,'publisher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45625,'pucker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45626,'pueblo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45631,'pug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45632,'pull');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45633,'pulmonary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45634,'pulp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45635,'pulsate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45636,'pulse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45641,'pulverize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45642,'puma');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45643,'pumice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45644,'pummel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45645,'punch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45646,'punctual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45651,'punctuate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45652,'punctured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45653,'pungent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45654,'punisher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45655,'punk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45656,'pupil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45661,'puppet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45662,'puppy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45663,'purchase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45664,'pureblood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45665,'purebred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (45666,'purely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46111,'pureness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46112,'purgatory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46113,'purge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46114,'purging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46115,'purifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46116,'purify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46121,'purist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46122,'puritan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46123,'purity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46124,'purple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46125,'purplish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46126,'purposely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46131,'purr');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46132,'purse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46133,'pursuable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46134,'pursuant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46135,'pursuit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46136,'purveyor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46141,'pushcart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46142,'pushchair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46143,'pusher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46144,'pushiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46145,'pushing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46146,'pushover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46151,'pushpin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46152,'pushup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46153,'pushy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46154,'putdown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46155,'putt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46156,'puzzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46161,'puzzling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46162,'pyramid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46163,'pyromania');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46164,'python');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46165,'quack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46166,'quadrant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46211,'quail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46212,'quaintly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46213,'quake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46214,'quaking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46215,'qualified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46216,'qualifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46221,'qualify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46222,'quality');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46223,'qualm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46224,'quantum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46225,'quarrel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46226,'quarry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46231,'quartered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46232,'quarterly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46233,'quarters');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46234,'quartet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46235,'quench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46236,'query');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46241,'quicken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46242,'quickly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46243,'quickness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46244,'quicksand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46245,'quickstep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46246,'quiet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46251,'quill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46252,'quilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46253,'quintet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46254,'quintuple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46255,'quirk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46256,'quit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46261,'quiver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46262,'quizzical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46263,'quotable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46264,'quotation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46265,'quote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46266,'rabid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46311,'race');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46312,'racing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46313,'racism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46314,'rack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46315,'racoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46316,'radar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46321,'radial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46322,'radiance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46323,'radiantly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46324,'radiated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46325,'radiation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46326,'radiator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46331,'radio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46332,'radish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46333,'raffle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46334,'raft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46335,'rage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46336,'ragged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46341,'raging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46342,'ragweed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46343,'raider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46344,'railcar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46345,'railing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46346,'railroad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46351,'railway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46352,'raisin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46353,'rake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46354,'raking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46355,'rally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46356,'ramble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46361,'rambling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46362,'ramp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46363,'ramrod');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46364,'ranch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46365,'rancidity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46366,'random');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46411,'ranged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46412,'ranger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46413,'ranging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46414,'ranked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46415,'ranking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46416,'ransack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46421,'ranting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46422,'rants');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46423,'rare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46424,'rarity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46425,'rascal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46426,'rash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46431,'rasping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46432,'ravage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46433,'raven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46434,'ravine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46435,'raving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46436,'ravioli');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46441,'ravishing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46442,'reabsorb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46443,'reach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46444,'reacquire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46445,'reaction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46446,'reactive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46451,'reactor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46452,'reaffirm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46453,'ream');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46454,'reanalyze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46455,'reappear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46456,'reapply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46461,'reappoint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46462,'reapprove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46463,'rearrange');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46464,'rearview');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46465,'reason');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46466,'reassign');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46511,'reassure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46512,'reattach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46513,'reawake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46514,'rebalance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46515,'rebate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46516,'rebel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46521,'rebirth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46522,'reboot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46523,'reborn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46524,'rebound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46525,'rebuff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46526,'rebuild');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46531,'rebuilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46532,'reburial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46533,'rebuttal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46534,'recall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46535,'recant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46536,'recapture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46541,'recast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46542,'recede');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46543,'recent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46544,'recess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46545,'recharger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46546,'recipient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46551,'recital');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46552,'recite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46553,'reckless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46554,'reclaim');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46555,'recliner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46556,'reclining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46561,'recluse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46562,'reclusive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46563,'recognize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46564,'recoil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46565,'recollect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46566,'recolor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46611,'reconcile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46612,'reconfirm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46613,'reconvene');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46614,'recopy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46615,'record');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46616,'recount');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46621,'recoup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46622,'recovery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46623,'recreate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46624,'rectal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46625,'rectangle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46626,'rectified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46631,'rectify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46632,'recycled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46633,'recycler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46634,'recycling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46635,'reemerge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46636,'reenact');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46641,'reenter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46642,'reentry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46643,'reexamine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46644,'referable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46645,'referee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46646,'reference');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46651,'refill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46652,'refinance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46653,'refined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46654,'refinery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46655,'refining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46656,'refinish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46661,'reflected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46662,'reflector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46663,'reflex');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46664,'reflux');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46665,'refocus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (46666,'refold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51111,'reforest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51112,'reformat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51113,'reformed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51114,'reformer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51115,'reformist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51116,'refract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51121,'refrain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51122,'refreeze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51123,'refresh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51124,'refried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51125,'refueling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51126,'refund');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51131,'refurbish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51132,'refurnish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51133,'refusal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51134,'refuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51135,'refusing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51136,'refutable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51141,'refute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51142,'regain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51143,'regalia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51144,'regally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51145,'reggae');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51146,'regime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51151,'region');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51152,'register');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51153,'registrar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51154,'registry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51155,'regress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51156,'regretful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51161,'regroup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51162,'regular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51163,'regulate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51164,'regulator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51165,'rehab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51166,'reheat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51211,'rehire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51212,'rehydrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51213,'reimburse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51214,'reissue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51215,'reiterate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51216,'rejoice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51221,'rejoicing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51222,'rejoin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51223,'rekindle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51224,'relapse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51225,'relapsing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51226,'relatable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51231,'related');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51232,'relation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51233,'relative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51234,'relax');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51235,'relay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51236,'relearn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51241,'release');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51242,'relenting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51243,'reliable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51244,'reliably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51245,'reliance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51246,'reliant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51251,'relic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51252,'relieve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51253,'relieving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51254,'relight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51255,'relish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51256,'relive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51261,'reload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51262,'relocate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51263,'relock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51264,'reluctant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51265,'rely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51266,'remake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51311,'remark');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51312,'remarry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51313,'rematch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51314,'remedial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51315,'remedy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51316,'remember');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51321,'reminder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51322,'remindful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51323,'remission');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51324,'remix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51325,'remnant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51326,'remodeler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51331,'remold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51332,'remorse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51333,'remote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51334,'removable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51335,'removal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51336,'removed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51341,'remover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51342,'removing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51343,'rename');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51344,'renderer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51345,'rendering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51346,'rendition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51351,'renegade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51352,'renewable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51353,'renewably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51354,'renewal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51355,'renewed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51356,'renounce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51361,'renovate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51362,'renovator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51363,'rentable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51364,'rental');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51365,'rented');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51366,'renter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51411,'reoccupy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51412,'reoccur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51413,'reopen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51414,'reorder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51415,'repackage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51416,'repacking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51421,'repaint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51422,'repair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51423,'repave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51424,'repaying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51425,'repayment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51426,'repeal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51431,'repeated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51432,'repeater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51433,'repent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51434,'rephrase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51435,'replace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51436,'replay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51441,'replica');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51442,'reply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51443,'reporter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51444,'repose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51445,'repossess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51446,'repost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51451,'repressed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51452,'reprimand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51453,'reprint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51454,'reprise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51455,'reproach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51456,'reprocess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51461,'reproduce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51462,'reprogram');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51463,'reps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51464,'reptile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51465,'reptilian');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51466,'repugnant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51511,'repulsion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51512,'repulsive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51513,'repurpose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51514,'reputable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51515,'reputably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51516,'request');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51521,'require');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51522,'requisite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51523,'reroute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51524,'rerun');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51525,'resale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51526,'resample');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51531,'rescuer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51532,'reseal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51533,'research');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51534,'reselect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51535,'reseller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51536,'resemble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51541,'resend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51542,'resent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51543,'reset');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51544,'reshape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51545,'reshoot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51546,'reshuffle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51551,'residence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51552,'residency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51553,'resident');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51554,'residual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51555,'residue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51556,'resigned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51561,'resilient');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51562,'resistant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51563,'resisting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51564,'resize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51565,'resolute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51566,'resolved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51611,'resonant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51612,'resonate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51613,'resort');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51614,'resource');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51615,'respect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51616,'resubmit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51621,'result');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51622,'resume');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51623,'resupply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51624,'resurface');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51625,'resurrect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51626,'retail');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51631,'retainer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51632,'retaining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51633,'retake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51634,'retaliate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51635,'retention');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51636,'rethink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51641,'retinal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51642,'retired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51643,'retiree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51644,'retiring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51645,'retold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51646,'retool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51651,'retorted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51652,'retouch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51653,'retrace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51654,'retract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51655,'retrain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51656,'retread');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51661,'retreat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51662,'retrial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51663,'retrieval');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51664,'retriever');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51665,'retry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (51666,'return');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52111,'retying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52112,'retype');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52113,'reunion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52114,'reunite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52115,'reusable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52116,'reuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52121,'reveal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52122,'reveler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52123,'revenge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52124,'revenue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52125,'reverb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52126,'revered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52131,'reverence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52132,'reverend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52133,'reversal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52134,'reverse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52135,'reversing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52136,'reversion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52141,'revert');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52142,'revisable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52143,'revise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52144,'revision');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52145,'revisit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52146,'revivable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52151,'revival');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52152,'reviver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52153,'reviving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52154,'revocable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52155,'revoke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52156,'revolt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52161,'revolver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52162,'revolving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52163,'reward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52164,'rewash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52165,'rewind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52166,'rewire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52211,'reword');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52212,'rework');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52213,'rewrap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52214,'rewrite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52215,'rhyme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52216,'ribbon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52221,'ribcage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52222,'rice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52223,'riches');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52224,'richly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52225,'richness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52226,'rickety');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52231,'ricotta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52232,'riddance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52233,'ridden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52234,'ride');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52235,'riding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52236,'rifling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52241,'rift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52242,'rigging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52243,'rigid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52244,'rigor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52245,'rimless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52246,'rimmed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52251,'rind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52252,'rink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52253,'rinse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52254,'rinsing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52255,'riot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52256,'ripcord');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52261,'ripeness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52262,'ripening');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52263,'ripping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52264,'ripple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52265,'rippling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52266,'riptide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52311,'rise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52312,'rising');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52313,'risk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52314,'risotto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52315,'ritalin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52316,'ritzy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52321,'rival');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52322,'riverbank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52323,'riverbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52324,'riverboat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52325,'riverside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52326,'riveter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52331,'riveting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52332,'roamer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52333,'roaming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52334,'roast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52335,'robbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52336,'robe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52341,'robin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52342,'robotics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52343,'robust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52344,'rockband');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52345,'rocker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52346,'rocket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52351,'rockfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52352,'rockiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52353,'rocking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52354,'rocklike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52355,'rockslide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52356,'rockstar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52361,'rocky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52362,'rogue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52363,'roman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52364,'romp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52365,'rope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52366,'roping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52411,'roster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52412,'rosy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52413,'rotten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52414,'rotting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52415,'rotunda');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52416,'roulette');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52421,'rounding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52422,'roundish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52423,'roundness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52424,'roundup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52425,'roundworm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52426,'routine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52431,'routing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52432,'rover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52433,'roving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52434,'royal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52435,'rubbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52436,'rubber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52441,'rubbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52442,'rubble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52443,'rubdown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52444,'ruby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52445,'ruckus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52446,'rudder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52451,'rug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52452,'ruined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52453,'rule');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52454,'rumble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52455,'rumbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52456,'rummage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52461,'rumor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52462,'runaround');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52463,'rundown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52464,'runner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52465,'running');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52466,'runny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52511,'runt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52512,'runway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52513,'rupture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52514,'rural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52515,'ruse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52516,'rush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52521,'rust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52522,'rut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52523,'sabbath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52524,'sabotage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52525,'sacrament');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52526,'sacred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52531,'sacrifice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52532,'sadden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52533,'saddlebag');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52534,'saddled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52535,'saddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52536,'sadly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52541,'sadness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52542,'safari');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52543,'safeguard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52544,'safehouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52545,'safely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52546,'safeness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52551,'saffron');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52552,'saga');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52553,'sage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52554,'sagging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52555,'saggy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52556,'said');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52561,'saint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52562,'sake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52563,'salad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52564,'salami');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52565,'salaried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52566,'salary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52611,'saline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52612,'salon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52613,'saloon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52614,'salsa');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52615,'salt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52616,'salutary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52621,'salute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52622,'salvage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52623,'salvaging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52624,'salvation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52625,'same');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52626,'sample');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52631,'sampling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52632,'sanction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52633,'sanctity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52634,'sanctuary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52635,'sandal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52636,'sandbag');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52641,'sandbank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52642,'sandbar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52643,'sandblast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52644,'sandbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52645,'sanded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52646,'sandfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52651,'sanding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52652,'sandlot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52653,'sandpaper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52654,'sandpit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52655,'sandstone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52656,'sandstorm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52661,'sandworm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52662,'sandy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52663,'sanitary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52664,'sanitizer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52665,'sank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (52666,'santa');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53111,'sapling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53112,'sappiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53113,'sappy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53114,'sarcasm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53115,'sarcastic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53116,'sardine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53121,'sash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53122,'sasquatch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53123,'sassy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53124,'satchel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53125,'satiable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53126,'satin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53131,'satirical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53132,'satisfied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53133,'satisfy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53134,'saturate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53135,'saturday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53136,'sauciness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53141,'saucy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53142,'sauna');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53143,'savage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53144,'savanna');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53145,'saved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53146,'savings');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53151,'savior');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53152,'savor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53153,'saxophone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53154,'say');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53155,'scabbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53156,'scabby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53161,'scalded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53162,'scalding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53163,'scale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53164,'scaling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53165,'scallion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53166,'scallop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53211,'scalping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53212,'scam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53213,'scandal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53214,'scanner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53215,'scanning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53216,'scant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53221,'scapegoat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53222,'scarce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53223,'scarcity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53224,'scarecrow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53225,'scared');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53226,'scarf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53231,'scarily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53232,'scariness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53233,'scarring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53234,'scary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53235,'scavenger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53236,'scenic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53241,'schedule');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53242,'schematic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53243,'scheme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53244,'scheming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53245,'schilling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53246,'schnapps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53251,'scholar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53252,'science');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53253,'scientist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53254,'scion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53255,'scoff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53256,'scolding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53261,'scone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53262,'scoop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53263,'scooter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53264,'scope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53265,'scorch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53266,'scorebook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53311,'scorecard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53312,'scored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53313,'scoreless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53314,'scorer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53315,'scoring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53316,'scorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53321,'scorpion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53322,'scotch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53323,'scoundrel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53324,'scoured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53325,'scouring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53326,'scouting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53331,'scouts');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53332,'scowling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53333,'scrabble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53334,'scraggly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53335,'scrambled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53336,'scrambler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53341,'scrap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53342,'scratch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53343,'scrawny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53344,'screen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53345,'scribble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53346,'scribe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53351,'scribing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53352,'scrimmage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53353,'script');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53354,'scroll');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53355,'scrooge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53356,'scrounger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53361,'scrubbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53362,'scrubber');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53363,'scruffy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53364,'scrunch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53365,'scrutiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53366,'scuba');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53411,'scuff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53412,'sculptor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53413,'sculpture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53414,'scurvy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53415,'scuttle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53416,'secluded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53421,'secluding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53422,'seclusion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53423,'second');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53424,'secrecy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53425,'secret');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53426,'sectional');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53431,'sector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53432,'secular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53433,'securely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53434,'security');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53435,'sedan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53436,'sedate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53441,'sedation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53442,'sedative');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53443,'sediment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53444,'seduce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53445,'seducing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53446,'segment');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53451,'seismic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53452,'seizing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53453,'seldom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53454,'selected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53455,'selection');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53456,'selective');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53461,'selector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53462,'self');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53463,'seltzer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53464,'semantic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53465,'semester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53466,'semicolon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53511,'semifinal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53512,'seminar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53513,'semisoft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53514,'semisweet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53515,'senate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53516,'senator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53521,'send');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53522,'senior');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53523,'senorita');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53524,'sensation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53525,'sensitive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53526,'sensitize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53531,'sensually');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53532,'sensuous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53533,'sepia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53534,'september');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53535,'septic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53536,'septum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53541,'sequel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53542,'sequence');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53543,'sequester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53544,'series');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53545,'sermon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53546,'serotonin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53551,'serpent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53552,'serrated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53553,'serve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53554,'service');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53555,'serving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53556,'sesame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53561,'sessions');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53562,'setback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53563,'setting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53564,'settle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53565,'settling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53566,'setup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53611,'sevenfold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53612,'seventeen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53613,'seventh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53614,'seventy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53615,'severity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53616,'shabby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53621,'shack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53622,'shaded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53623,'shadily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53624,'shadiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53625,'shading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53626,'shadow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53631,'shady');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53632,'shaft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53633,'shakable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53634,'shakily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53635,'shakiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53636,'shaking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53641,'shaky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53642,'shale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53643,'shallot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53644,'shallow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53645,'shame');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53646,'shampoo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53651,'shamrock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53652,'shank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53653,'shanty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53654,'shape');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53655,'shaping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53656,'share');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53661,'sharpener');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53662,'sharper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53663,'sharpie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53664,'sharply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53665,'sharpness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (53666,'shawl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54111,'sheath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54112,'shed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54113,'sheep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54114,'sheet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54115,'shelf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54116,'shell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54121,'shelter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54122,'shelve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54123,'shelving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54124,'sherry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54125,'shield');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54126,'shifter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54131,'shifting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54132,'shiftless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54133,'shifty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54134,'shimmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54135,'shimmy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54136,'shindig');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54141,'shine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54142,'shingle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54143,'shininess');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54144,'shining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54145,'shiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54146,'ship');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54151,'shirt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54152,'shivering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54153,'shock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54154,'shone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54155,'shoplift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54156,'shopper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54161,'shopping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54162,'shoptalk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54163,'shore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54164,'shortage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54165,'shortcake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54166,'shortcut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54211,'shorten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54212,'shorter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54213,'shorthand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54214,'shortlist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54215,'shortly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54216,'shortness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54221,'shorts');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54222,'shortwave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54223,'shorty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54224,'shout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54225,'shove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54226,'showbiz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54231,'showcase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54232,'showdown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54233,'shower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54234,'showgirl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54235,'showing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54236,'showman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54241,'shown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54242,'showoff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54243,'showpiece');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54244,'showplace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54245,'showroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54246,'showy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54251,'shrank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54252,'shrapnel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54253,'shredder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54254,'shredding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54255,'shrewdly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54256,'shriek');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54261,'shrill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54262,'shrimp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54263,'shrine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54264,'shrink');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54265,'shrivel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54266,'shrouded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54311,'shrubbery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54312,'shrubs');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54313,'shrug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54314,'shrunk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54315,'shucking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54316,'shudder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54321,'shuffle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54322,'shuffling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54323,'shun');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54324,'shush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54325,'shut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54326,'shy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54331,'siamese');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54332,'siberian');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54333,'sibling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54334,'siding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54335,'sierra');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54336,'siesta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54341,'sift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54342,'sighing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54343,'silenced');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54344,'silencer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54345,'silent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54346,'silica');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54351,'silicon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54352,'silk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54353,'silliness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54354,'silly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54355,'silo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54356,'silt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54361,'silver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54362,'similarly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54363,'simile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54364,'simmering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54365,'simple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54366,'simplify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54411,'simply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54412,'sincere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54413,'sincerity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54414,'singer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54415,'singing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54416,'single');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54421,'singular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54422,'sinister');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54423,'sinless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54424,'sinner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54425,'sinuous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54426,'sip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54431,'siren');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54432,'sister');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54433,'sitcom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54434,'sitter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54435,'sitting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54436,'situated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54441,'situation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54442,'sixfold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54443,'sixteen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54444,'sixth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54445,'sixties');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54446,'sixtieth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54451,'sixtyfold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54452,'sizable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54453,'sizably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54454,'size');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54455,'sizing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54456,'sizzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54461,'sizzling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54462,'skater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54463,'skating');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54464,'skedaddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54465,'skeletal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54466,'skeleton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54511,'skeptic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54512,'sketch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54513,'skewed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54514,'skewer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54515,'skid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54516,'skied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54521,'skier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54522,'skies');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54523,'skiing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54524,'skilled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54525,'skillet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54526,'skillful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54531,'skimmed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54532,'skimmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54533,'skimming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54534,'skimpily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54535,'skincare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54536,'skinhead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54541,'skinless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54542,'skinning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54543,'skinny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54544,'skintight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54545,'skipper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54546,'skipping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54551,'skirmish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54552,'skirt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54553,'skittle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54554,'skydiver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54555,'skylight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54556,'skyline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54561,'skype');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54562,'skyrocket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54563,'skyward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54564,'slab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54565,'slacked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54566,'slacker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54611,'slacking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54612,'slackness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54613,'slacks');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54614,'slain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54615,'slam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54616,'slander');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54621,'slang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54622,'slapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54623,'slapstick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54624,'slashed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54625,'slashing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54626,'slate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54631,'slather');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54632,'slaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54633,'sled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54634,'sleek');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54635,'sleep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54636,'sleet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54641,'sleeve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54642,'slept');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54643,'sliceable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54644,'sliced');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54645,'slicer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54646,'slicing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54651,'slick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54652,'slider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54653,'slideshow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54654,'sliding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54655,'slighted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54656,'slighting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54661,'slightly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54662,'slimness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54663,'slimy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54664,'slinging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54665,'slingshot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (54666,'slinky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55111,'slip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55112,'slit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55113,'sliver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55114,'slobbery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55115,'slogan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55116,'sloped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55121,'sloping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55122,'sloppily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55123,'sloppy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55124,'slot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55125,'slouching');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55126,'slouchy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55131,'sludge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55132,'slug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55133,'slum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55134,'slurp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55135,'slush');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55136,'sly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55141,'small');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55142,'smartly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55143,'smartness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55144,'smasher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55145,'smashing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55146,'smashup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55151,'smell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55152,'smelting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55153,'smile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55154,'smilingly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55155,'smirk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55156,'smite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55161,'smith');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55162,'smitten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55163,'smock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55164,'smog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55165,'smoked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55166,'smokeless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55211,'smokiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55212,'smoking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55213,'smoky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55214,'smolder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55215,'smooth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55216,'smother');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55221,'smudge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55222,'smudgy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55223,'smuggler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55224,'smuggling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55225,'smugly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55226,'smugness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55231,'snack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55232,'snagged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55233,'snaking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55234,'snap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55235,'snare');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55236,'snarl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55241,'snazzy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55242,'sneak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55243,'sneer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55244,'sneeze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55245,'sneezing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55246,'snide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55251,'sniff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55252,'snippet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55253,'snipping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55254,'snitch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55255,'snooper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55256,'snooze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55261,'snore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55262,'snoring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55263,'snorkel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55264,'snort');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55265,'snout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55266,'snowbird');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55311,'snowboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55312,'snowbound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55313,'snowcap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55314,'snowdrift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55315,'snowdrop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55316,'snowfall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55321,'snowfield');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55322,'snowflake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55323,'snowiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55324,'snowless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55325,'snowman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55326,'snowplow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55331,'snowshoe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55332,'snowstorm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55333,'snowsuit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55334,'snowy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55335,'snub');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55336,'snuff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55341,'snuggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55342,'snugly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55343,'snugness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55344,'speak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55345,'spearfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55346,'spearhead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55351,'spearman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55352,'spearmint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55353,'species');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55354,'specimen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55355,'specked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55356,'speckled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55361,'specks');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55362,'spectacle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55363,'spectator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55364,'spectrum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55365,'speculate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55366,'speech');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55411,'speed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55412,'spellbind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55413,'speller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55414,'spelling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55415,'spendable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55416,'spender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55421,'spending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55422,'spent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55423,'spew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55424,'sphere');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55425,'spherical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55426,'sphinx');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55431,'spider');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55432,'spied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55433,'spiffy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55434,'spill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55435,'spilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55436,'spinach');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55441,'spinal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55442,'spindle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55443,'spinner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55444,'spinning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55445,'spinout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55446,'spinster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55451,'spiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55452,'spiral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55453,'spirited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55454,'spiritism');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55455,'spirits');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55456,'spiritual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55461,'splashed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55462,'splashing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55463,'splashy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55464,'splatter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55465,'spleen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55466,'splendid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55511,'splendor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55512,'splice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55513,'splicing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55514,'splinter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55515,'splotchy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55516,'splurge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55521,'spoilage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55522,'spoiled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55523,'spoiler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55524,'spoiling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55525,'spoils');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55526,'spoken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55531,'spokesman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55532,'sponge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55533,'spongy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55534,'sponsor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55535,'spoof');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55536,'spookily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55541,'spooky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55542,'spool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55543,'spoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55544,'spore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55545,'sporting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55546,'sports');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55551,'sporty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55552,'spotless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55553,'spotlight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55554,'spotted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55555,'spotter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55556,'spotting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55561,'spotty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55562,'spousal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55563,'spouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55564,'spout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55565,'sprain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55566,'sprang');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55611,'sprawl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55612,'spray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55613,'spree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55614,'sprig');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55615,'spring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55616,'sprinkled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55621,'sprinkler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55622,'sprint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55623,'sprite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55624,'sprout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55625,'spruce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55626,'sprung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55631,'spry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55632,'spud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55633,'spur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55634,'sputter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55635,'spyglass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55636,'squabble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55641,'squad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55642,'squall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55643,'squander');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55644,'squash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55645,'squatted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55646,'squatter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55651,'squatting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55652,'squeak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55653,'squealer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55654,'squealing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55655,'squeamish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55656,'squeegee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55661,'squeeze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55662,'squeezing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55663,'squid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55664,'squiggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55665,'squiggly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (55666,'squint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56111,'squire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56112,'squirt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56113,'squishier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56114,'squishy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56115,'stability');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56116,'stabilize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56121,'stable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56122,'stack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56123,'stadium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56124,'staff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56125,'stage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56126,'staging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56131,'stagnant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56132,'stagnate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56133,'stainable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56134,'stained');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56135,'staining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56136,'stainless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56141,'stalemate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56142,'staleness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56143,'stalling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56144,'stallion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56145,'stamina');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56146,'stammer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56151,'stamp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56152,'stand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56153,'stank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56154,'staple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56155,'stapling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56156,'starboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56161,'starch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56162,'stardom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56163,'stardust');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56164,'starfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56165,'stargazer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56166,'staring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56211,'stark');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56212,'starless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56213,'starlet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56214,'starlight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56215,'starlit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56216,'starring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56221,'starry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56222,'starship');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56223,'starter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56224,'starting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56225,'startle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56226,'startling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56231,'startup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56232,'starved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56233,'starving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56234,'stash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56235,'state');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56236,'static');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56241,'statistic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56242,'statue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56243,'stature');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56244,'status');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56245,'statute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56246,'statutory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56251,'staunch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56252,'stays');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56253,'steadfast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56254,'steadier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56255,'steadily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56256,'steadying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56261,'steam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56262,'steed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56263,'steep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56264,'steerable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56265,'steering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56266,'steersman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56311,'stegosaur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56312,'stellar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56313,'stem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56314,'stench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56315,'stencil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56316,'step');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56321,'stereo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56322,'sterile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56323,'sterility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56324,'sterilize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56325,'sterling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56326,'sternness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56331,'sternum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56332,'stew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56333,'stick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56334,'stiffen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56335,'stiffly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56336,'stiffness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56341,'stifle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56342,'stifling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56343,'stillness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56344,'stilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56345,'stimulant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56346,'stimulate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56351,'stimuli');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56352,'stimulus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56353,'stinger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56354,'stingily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56355,'stinging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56356,'stingray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56361,'stingy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56362,'stinking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56363,'stinky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56364,'stipend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56365,'stipulate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56366,'stir');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56411,'stitch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56412,'stock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56413,'stoic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56414,'stoke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56415,'stole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56416,'stomp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56421,'stonewall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56422,'stoneware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56423,'stonework');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56424,'stoning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56425,'stony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56426,'stood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56431,'stooge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56432,'stool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56433,'stoop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56434,'stoplight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56435,'stoppable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56436,'stoppage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56441,'stopped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56442,'stopper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56443,'stopping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56444,'stopwatch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56445,'storable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56446,'storage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56451,'storeroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56452,'storewide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56453,'storm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56454,'stout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56455,'stove');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56456,'stowaway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56461,'stowing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56462,'straddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56463,'straggler');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56464,'strained');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56465,'strainer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56466,'straining');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56511,'strangely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56512,'stranger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56513,'strangle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56514,'strategic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56515,'strategy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56516,'stratus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56521,'straw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56522,'stray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56523,'streak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56524,'stream');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56525,'street');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56526,'strength');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56531,'strenuous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56532,'strep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56533,'stress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56534,'stretch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56535,'strewn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56536,'stricken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56541,'strict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56542,'stride');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56543,'strife');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56544,'strike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56545,'striking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56546,'strive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56551,'striving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56552,'strobe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56553,'strode');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56554,'stroller');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56555,'strongbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56556,'strongly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56561,'strongman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56562,'struck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56563,'structure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56564,'strudel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56565,'struggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56566,'strum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56611,'strung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56612,'strut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56613,'stubbed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56614,'stubble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56615,'stubbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56616,'stubborn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56621,'stucco');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56622,'stuck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56623,'student');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56624,'studied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56625,'studio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56626,'study');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56631,'stuffed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56632,'stuffing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56633,'stuffy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56634,'stumble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56635,'stumbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56636,'stump');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56641,'stung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56642,'stunned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56643,'stunner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56644,'stunning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56645,'stunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56646,'stupor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56651,'sturdily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56652,'sturdy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56653,'styling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56654,'stylishly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56655,'stylist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56656,'stylized');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56661,'stylus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56662,'suave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56663,'subarctic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56664,'subatomic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56665,'subdivide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (56666,'subdued');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61111,'subduing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61112,'subfloor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61113,'subgroup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61114,'subheader');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61115,'subject');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61116,'sublease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61121,'sublet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61122,'sublevel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61123,'sublime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61124,'submarine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61125,'submerge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61126,'submersed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61131,'submitter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61132,'subpanel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61133,'subpar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61134,'subplot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61135,'subprime');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61136,'subscribe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61141,'subscript');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61142,'subsector');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61143,'subside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61144,'subsiding');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61145,'subsidize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61146,'subsidy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61151,'subsoil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61152,'subsonic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61153,'substance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61154,'subsystem');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61155,'subtext');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61156,'subtitle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61161,'subtly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61162,'subtotal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61163,'subtract');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61164,'subtype');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61165,'suburb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61166,'subway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61211,'subwoofer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61212,'subzero');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61213,'succulent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61214,'such');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61215,'suction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61216,'sudden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61221,'sudoku');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61222,'suds');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61223,'sufferer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61224,'suffering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61225,'suffice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61226,'suffix');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61231,'suffocate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61232,'suffrage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61233,'sugar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61234,'suggest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61235,'suing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61236,'suitable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61241,'suitably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61242,'suitcase');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61243,'suitor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61244,'sulfate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61245,'sulfide');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61246,'sulfite');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61251,'sulfur');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61252,'sulk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61253,'sullen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61254,'sulphate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61255,'sulphuric');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61256,'sultry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61261,'superbowl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61262,'superglue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61263,'superhero');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61264,'superior');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61265,'superjet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61266,'superman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61311,'supermom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61312,'supernova');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61313,'supervise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61314,'supper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61315,'supplier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61316,'supply');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61321,'support');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61322,'supremacy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61323,'supreme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61324,'surcharge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61325,'surely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61326,'sureness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61331,'surface');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61332,'surfacing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61333,'surfboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61334,'surfer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61335,'surgery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61336,'surgical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61341,'surging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61342,'surname');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61343,'surpass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61344,'surplus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61345,'surprise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61346,'surreal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61351,'surrender');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61352,'surrogate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61353,'surround');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61354,'survey');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61355,'survival');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61356,'survive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61361,'surviving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61362,'survivor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61363,'sushi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61364,'suspect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61365,'suspend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61366,'suspense');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61411,'sustained');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61412,'sustainer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61413,'swab');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61414,'swaddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61415,'swagger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61416,'swampland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61421,'swan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61422,'swapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61423,'swarm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61424,'sway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61425,'swear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61426,'sweat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61431,'sweep');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61432,'swell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61433,'swept');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61434,'swerve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61435,'swifter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61436,'swiftly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61441,'swiftness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61442,'swimmable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61443,'swimmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61444,'swimming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61445,'swimsuit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61446,'swimwear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61451,'swinger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61452,'swinging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61453,'swipe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61454,'swirl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61455,'switch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61456,'swivel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61461,'swizzle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61462,'swooned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61463,'swoop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61464,'swoosh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61465,'swore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61466,'sworn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61511,'swung');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61512,'sycamore');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61513,'sympathy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61514,'symphonic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61515,'symphony');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61516,'symptom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61521,'synapse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61522,'syndrome');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61523,'synergy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61524,'synopses');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61525,'synopsis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61526,'synthesis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61531,'synthetic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61532,'syrup');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61533,'system');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61534,'t-shirt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61535,'tabasco');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61536,'tabby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61541,'tableful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61542,'tables');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61543,'tablet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61544,'tableware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61545,'tabloid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61546,'tackiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61551,'tacking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61552,'tackle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61553,'tackling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61554,'tacky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61555,'taco');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61556,'tactful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61561,'tactical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61562,'tactics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61563,'tactile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61564,'tactless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61565,'tadpole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61566,'taekwondo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61611,'tag');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61612,'tainted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61613,'take');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61614,'taking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61615,'talcum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61616,'talisman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61621,'tall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61622,'talon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61623,'tamale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61624,'tameness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61625,'tamer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61626,'tamper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61631,'tank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61632,'tanned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61633,'tannery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61634,'tanning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61635,'tantrum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61636,'tapeless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61641,'tapered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61642,'tapering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61643,'tapestry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61644,'tapioca');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61645,'tapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61646,'taps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61651,'tarantula');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61652,'target');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61653,'tarmac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61654,'tarnish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61655,'tarot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61656,'tartar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61661,'tartly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61662,'tartness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61663,'task');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61664,'tassel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61665,'taste');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (61666,'tastiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62111,'tasting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62112,'tasty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62113,'tattered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62114,'tattle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62115,'tattling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62116,'tattoo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62121,'taunt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62122,'tavern');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62123,'thank');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62124,'that');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62125,'thaw');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62126,'theater');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62131,'theatrics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62132,'thee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62133,'theft');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62134,'theme');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62135,'theology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62136,'theorize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62141,'thermal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62142,'thermos');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62143,'thesaurus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62144,'these');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62145,'thesis');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62146,'thespian');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62151,'thicken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62152,'thicket');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62153,'thickness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62154,'thieving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62155,'thievish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62156,'thigh');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62161,'thimble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62162,'thing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62163,'think');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62164,'thinly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62165,'thinner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62166,'thinness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62211,'thinning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62212,'thirstily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62213,'thirsting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62214,'thirsty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62215,'thirteen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62216,'thirty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62221,'thong');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62222,'thorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62223,'those');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62224,'thousand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62225,'thrash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62226,'thread');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62231,'threaten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62232,'threefold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62233,'thrift');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62234,'thrill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62235,'thrive');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62236,'thriving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62241,'throat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62242,'throbbing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62243,'throng');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62244,'throttle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62245,'throwaway');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62246,'throwback');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62251,'thrower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62252,'throwing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62253,'thud');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62254,'thumb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62255,'thumping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62256,'thursday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62261,'thus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62262,'thwarting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62263,'thyself');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62264,'tiara');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62265,'tibia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62266,'tidal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62311,'tidbit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62312,'tidiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62313,'tidings');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62314,'tidy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62315,'tiger');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62316,'tighten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62321,'tightly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62322,'tightness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62323,'tightrope');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62324,'tightwad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62325,'tigress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62326,'tile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62331,'tiling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62332,'till');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62333,'tilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62334,'timid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62335,'timing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62336,'timothy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62341,'tinderbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62342,'tinfoil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62343,'tingle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62344,'tingling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62345,'tingly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62346,'tinker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62351,'tinkling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62352,'tinsel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62353,'tinsmith');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62354,'tint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62355,'tinwork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62356,'tiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62361,'tipoff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62362,'tipped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62363,'tipper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62364,'tipping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62365,'tiptoeing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62366,'tiptop');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62411,'tiring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62412,'tissue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62413,'trace');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62414,'tracing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62415,'track');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62416,'traction');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62421,'tractor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62422,'trade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62423,'trading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62424,'tradition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62425,'traffic');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62426,'tragedy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62431,'trailing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62432,'trailside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62433,'train');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62434,'traitor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62435,'trance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62436,'tranquil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62441,'transfer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62442,'transform');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62443,'translate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62444,'transpire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62445,'transport');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62446,'transpose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62451,'trapdoor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62452,'trapeze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62453,'trapezoid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62454,'trapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62455,'trapper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62456,'trapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62461,'traps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62462,'trash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62463,'travel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62464,'traverse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62465,'travesty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62466,'tray');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62511,'treachery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62512,'treading');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62513,'treadmill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62514,'treason');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62515,'treat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62516,'treble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62521,'tree');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62522,'trekker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62523,'tremble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62524,'trembling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62525,'tremor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62526,'trench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62531,'trend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62532,'trespass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62533,'triage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62534,'trial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62535,'triangle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62536,'tribesman');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62541,'tribunal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62542,'tribune');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62543,'tributary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62544,'tribute');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62545,'triceps');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62546,'trickery');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62551,'trickily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62552,'tricking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62553,'trickle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62554,'trickster');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62555,'tricky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62556,'tricolor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62561,'tricycle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62562,'trident');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62563,'tried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62564,'trifle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62565,'trifocals');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62566,'trillion');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62611,'trilogy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62612,'trimester');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62613,'trimmer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62614,'trimming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62615,'trimness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62616,'trinity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62621,'trio');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62622,'tripod');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62623,'tripping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62624,'triumph');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62625,'trivial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62626,'trodden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62631,'trolling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62632,'trombone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62633,'trophy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62634,'tropical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62635,'tropics');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62636,'trouble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62641,'troubling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62642,'trough');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62643,'trousers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62644,'trout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62645,'trowel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62646,'truce');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62651,'truck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62652,'truffle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62653,'trump');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62654,'trunks');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62655,'trustable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62656,'trustee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62661,'trustful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62662,'trusting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62663,'trustless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62664,'truth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62665,'try');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (62666,'tubby');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63111,'tubeless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63112,'tubular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63113,'tucking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63114,'tuesday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63115,'tug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63116,'tuition');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63121,'tulip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63122,'tumble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63123,'tumbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63124,'tummy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63125,'turban');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63126,'turbine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63131,'turbofan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63132,'turbojet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63133,'turbulent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63134,'turf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63135,'turkey');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63136,'turmoil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63141,'turret');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63142,'turtle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63143,'tusk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63144,'tutor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63145,'tutu');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63146,'tux');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63151,'tweak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63152,'tweed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63153,'tweet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63154,'tweezers');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63155,'twelve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63156,'twentieth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63161,'twenty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63162,'twerp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63163,'twice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63164,'twiddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63165,'twiddling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63166,'twig');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63211,'twilight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63212,'twine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63213,'twins');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63214,'twirl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63215,'twistable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63216,'twisted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63221,'twister');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63222,'twisting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63223,'twisty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63224,'twitch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63225,'twitter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63226,'tycoon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63231,'tying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63232,'tyke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63233,'udder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63234,'ultimate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63235,'ultimatum');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63236,'ultra');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63241,'umbilical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63242,'umbrella');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63243,'umpire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63244,'unabashed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63245,'unable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63246,'unadorned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63251,'unadvised');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63252,'unafraid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63253,'unaired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63254,'unaligned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63255,'unaltered');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63256,'unarmored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63261,'unashamed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63262,'unaudited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63263,'unawake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63264,'unaware');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63265,'unbaked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63266,'unbalance');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63311,'unbeaten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63312,'unbend');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63313,'unbent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63314,'unbiased');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63315,'unbitten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63316,'unblended');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63321,'unblessed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63322,'unblock');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63323,'unbolted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63324,'unbounded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63325,'unboxed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63326,'unbraided');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63331,'unbridle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63332,'unbroken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63333,'unbuckled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63334,'unbundle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63335,'unburned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63336,'unbutton');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63341,'uncanny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63342,'uncapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63343,'uncaring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63344,'uncertain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63345,'unchain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63346,'unchanged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63351,'uncharted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63352,'uncheck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63353,'uncivil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63354,'unclad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63355,'unclaimed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63356,'unclamped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63361,'unclasp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63362,'uncle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63363,'unclip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63364,'uncloak');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63365,'unclog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63366,'unclothed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63411,'uncoated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63412,'uncoiled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63413,'uncolored');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63414,'uncombed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63415,'uncommon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63416,'uncooked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63421,'uncork');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63422,'uncorrupt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63423,'uncounted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63424,'uncouple');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63425,'uncouth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63426,'uncover');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63431,'uncross');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63432,'uncrown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63433,'uncrushed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63434,'uncured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63435,'uncurious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63436,'uncurled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63441,'uncut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63442,'undamaged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63443,'undated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63444,'undaunted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63445,'undead');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63446,'undecided');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63451,'undefined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63452,'underage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63453,'underarm');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63454,'undercoat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63455,'undercook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63456,'undercut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63461,'underdog');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63462,'underdone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63463,'underfed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63464,'underfeed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63465,'underfoot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63466,'undergo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63511,'undergrad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63512,'underhand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63513,'underline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63514,'underling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63515,'undermine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63516,'undermost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63521,'underpaid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63522,'underpass');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63523,'underpay');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63524,'underrate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63525,'undertake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63526,'undertone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63531,'undertook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63532,'undertow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63533,'underuse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63534,'underwear');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63535,'underwent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63536,'underwire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63541,'undesired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63542,'undiluted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63543,'undivided');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63544,'undocked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63545,'undoing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63546,'undone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63551,'undrafted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63552,'undress');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63553,'undrilled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63554,'undusted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63555,'undying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63556,'unearned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63561,'unearth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63562,'unease');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63563,'uneasily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63564,'uneasy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63565,'uneatable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63566,'uneaten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63611,'unedited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63612,'unelected');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63613,'unending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63614,'unengaged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63615,'unenvied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63616,'unequal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63621,'unethical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63622,'uneven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63623,'unexpired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63624,'unexposed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63625,'unfailing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63626,'unfair');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63631,'unfasten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63632,'unfazed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63633,'unfeeling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63634,'unfiled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63635,'unfilled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63636,'unfitted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63641,'unfitting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63642,'unfixable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63643,'unfixed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63644,'unflawed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63645,'unfocused');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63646,'unfold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63651,'unfounded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63652,'unframed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63653,'unfreeze');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63654,'unfrosted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63655,'unfrozen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63656,'unfunded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63661,'unglazed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63662,'ungloved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63663,'unglue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63664,'ungodly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63665,'ungraded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (63666,'ungreased');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64111,'unguarded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64112,'unguided');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64113,'unhappily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64114,'unhappy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64115,'unharmed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64116,'unhealthy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64121,'unheard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64122,'unhearing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64123,'unheated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64124,'unhelpful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64125,'unhidden');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64126,'unhinge');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64131,'unhitched');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64132,'unholy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64133,'unhook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64134,'unicorn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64135,'unicycle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64136,'unified');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64141,'unifier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64142,'uniformed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64143,'uniformly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64144,'unify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64145,'unimpeded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64146,'uninjured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64151,'uninstall');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64152,'uninsured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64153,'uninvited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64154,'union');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64155,'uniquely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64156,'unisexual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64161,'unison');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64162,'unissued');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64163,'unit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64164,'universal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64165,'universe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64166,'unjustly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64211,'unkempt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64212,'unkind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64213,'unknotted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64214,'unknowing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64215,'unknown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64216,'unlaced');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64221,'unlatch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64222,'unlawful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64223,'unleaded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64224,'unlearned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64225,'unleash');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64226,'unless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64231,'unleveled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64232,'unlighted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64233,'unlikable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64234,'unlimited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64235,'unlined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64236,'unlinked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64241,'unlisted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64242,'unlit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64243,'unlivable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64244,'unloaded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64245,'unloader');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64246,'unlocked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64251,'unlocking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64252,'unlovable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64253,'unloved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64254,'unlovely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64255,'unloving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64256,'unluckily');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64261,'unlucky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64262,'unmade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64263,'unmanaged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64264,'unmanned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64265,'unmapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64266,'unmarked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64311,'unmasked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64312,'unmasking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64313,'unmatched');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64314,'unmindful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64315,'unmixable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64316,'unmixed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64321,'unmolded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64322,'unmoral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64323,'unmovable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64324,'unmoved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64325,'unmoving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64326,'unnamable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64331,'unnamed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64332,'unnatural');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64333,'unneeded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64334,'unnerve');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64335,'unnerving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64336,'unnoticed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64341,'unopened');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64342,'unopposed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64343,'unpack');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64344,'unpadded');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64345,'unpaid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64346,'unpainted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64351,'unpaired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64352,'unpaved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64353,'unpeeled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64354,'unpicked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64355,'unpiloted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64356,'unpinned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64361,'unplanned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64362,'unplanted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64363,'unpleased');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64364,'unpledged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64365,'unplowed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64366,'unplug');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64411,'unpopular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64412,'unproven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64413,'unquote');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64414,'unranked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64415,'unrated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64416,'unraveled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64421,'unreached');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64422,'unread');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64423,'unreal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64424,'unreeling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64425,'unrefined');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64426,'unrelated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64431,'unrented');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64432,'unrest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64433,'unretired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64434,'unrevised');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64435,'unrigged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64436,'unripe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64441,'unrivaled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64442,'unroasted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64443,'unrobed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64444,'unroll');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64445,'unruffled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64446,'unruly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64451,'unrushed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64452,'unsaddle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64453,'unsafe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64454,'unsaid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64455,'unsalted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64456,'unsaved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64461,'unsavory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64462,'unscathed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64463,'unscented');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64464,'unscrew');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64465,'unsealed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64466,'unseated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64511,'unsecured');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64512,'unseeing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64513,'unseemly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64514,'unseen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64515,'unselect');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64516,'unselfish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64521,'unsent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64522,'unsettled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64523,'unshackle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64524,'unshaken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64525,'unshaved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64526,'unshaven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64531,'unsheathe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64532,'unshipped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64533,'unsightly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64534,'unsigned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64535,'unskilled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64536,'unsliced');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64541,'unsmooth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64542,'unsnap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64543,'unsocial');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64544,'unsoiled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64545,'unsold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64546,'unsolved');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64551,'unsorted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64552,'unspoiled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64553,'unspoken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64554,'unstable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64555,'unstaffed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64556,'unstamped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64561,'unsteady');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64562,'unsterile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64563,'unstirred');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64564,'unstitch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64565,'unstopped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64566,'unstuck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64611,'unstuffed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64612,'unstylish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64613,'unsubtle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64614,'unsubtly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64615,'unsuited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64616,'unsure');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64621,'unsworn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64622,'untagged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64623,'untainted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64624,'untaken');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64625,'untamed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64626,'untangled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64631,'untapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64632,'untaxed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64633,'unthawed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64634,'unthread');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64635,'untidy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64636,'untie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64641,'until');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64642,'untimed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64643,'untimely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64644,'untitled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64645,'untoasted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64646,'untold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64651,'untouched');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64652,'untracked');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64653,'untrained');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64654,'untreated');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64655,'untried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64656,'untrimmed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64661,'untrue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64662,'untruth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64663,'unturned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64664,'untwist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64665,'untying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (64666,'unusable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65111,'unused');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65112,'unusual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65113,'unvalued');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65114,'unvaried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65115,'unvarying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65116,'unveiled');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65121,'unveiling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65122,'unvented');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65123,'unviable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65124,'unvisited');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65125,'unvocal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65126,'unwanted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65131,'unwarlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65132,'unwary');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65133,'unwashed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65134,'unwatched');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65135,'unweave');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65136,'unwed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65141,'unwelcome');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65142,'unwell');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65143,'unwieldy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65144,'unwilling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65145,'unwind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65146,'unwired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65151,'unwitting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65152,'unwomanly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65153,'unworldly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65154,'unworn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65155,'unworried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65156,'unworthy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65161,'unwound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65162,'unwoven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65163,'unwrapped');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65164,'unwritten');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65165,'unzip');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65166,'upbeat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65211,'upchuck');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65212,'upcoming');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65213,'upcountry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65214,'update');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65215,'upfront');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65216,'upgrade');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65221,'upheaval');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65222,'upheld');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65223,'uphill');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65224,'uphold');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65225,'uplifted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65226,'uplifting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65231,'upload');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65232,'upon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65233,'upper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65234,'upright');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65235,'uprising');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65236,'upriver');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65241,'uproar');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65242,'uproot');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65243,'upscale');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65244,'upside');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65245,'upstage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65246,'upstairs');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65251,'upstart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65252,'upstate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65253,'upstream');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65254,'upstroke');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65255,'upswing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65256,'uptake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65261,'uptight');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65262,'uptown');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65263,'upturned');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65264,'upward');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65265,'upwind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65266,'uranium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65311,'urban');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65312,'urchin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65313,'urethane');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65314,'urgency');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65315,'urgent');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65316,'urging');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65321,'urologist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65322,'urology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65323,'usable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65324,'usage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65325,'useable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65326,'used');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65331,'uselessly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65332,'user');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65333,'usher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65334,'usual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65335,'utensil');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65336,'utility');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65341,'utilize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65342,'utmost');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65343,'utopia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65344,'utter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65345,'vacancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65346,'vacant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65351,'vacate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65352,'vacation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65353,'vagabond');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65354,'vagrancy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65355,'vagrantly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65356,'vaguely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65361,'vagueness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65362,'valiant');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65363,'valid');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65364,'valium');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65365,'valley');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65366,'valuables');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65411,'value');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65412,'vanilla');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65413,'vanish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65414,'vanity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65415,'vanquish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65416,'vantage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65421,'vaporizer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65422,'variable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65423,'variably');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65424,'varied');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65425,'variety');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65426,'various');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65431,'varmint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65432,'varnish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65433,'varsity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65434,'varying');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65435,'vascular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65436,'vaseline');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65441,'vastly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65442,'vastness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65443,'veal');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65444,'vegan');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65445,'veggie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65446,'vehicular');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65451,'velcro');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65452,'velocity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65453,'velvet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65454,'vendetta');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65455,'vending');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65456,'vendor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65461,'veneering');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65462,'vengeful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65463,'venomous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65464,'ventricle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65465,'venture');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65466,'venue');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65511,'venus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65512,'verbalize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65513,'verbally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65514,'verbose');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65515,'verdict');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65516,'verify');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65521,'verse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65522,'version');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65523,'versus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65524,'vertebrae');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65525,'vertical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65526,'vertigo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65531,'very');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65532,'vessel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65533,'vest');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65534,'veteran');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65535,'veto');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65536,'vexingly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65541,'viability');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65542,'viable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65543,'vibes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65544,'vice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65545,'vicinity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65546,'victory');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65551,'video');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65552,'viewable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65553,'viewer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65554,'viewing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65555,'viewless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65556,'viewpoint');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65561,'vigorous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65562,'village');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65563,'villain');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65564,'vindicate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65565,'vineyard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65566,'vintage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65611,'violate');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65612,'violation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65613,'violator');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65614,'violet');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65615,'violin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65616,'viper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65621,'viral');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65622,'virtual');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65623,'virtuous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65624,'virus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65625,'visa');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65626,'viscosity');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65631,'viscous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65632,'viselike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65633,'visible');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65634,'visibly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65635,'vision');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65636,'visiting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65641,'visitor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65642,'visor');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65643,'vista');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65644,'vitality');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65645,'vitalize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65646,'vitally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65651,'vitamins');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65652,'vivacious');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65653,'vividly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65654,'vividness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65655,'vixen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65656,'vocalist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65661,'vocalize');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65662,'vocally');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65663,'vocation');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65664,'voice');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65665,'voicing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (65666,'void');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66111,'volatile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66112,'volley');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66113,'voltage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66114,'volumes');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66115,'voter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66116,'voting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66121,'voucher');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66122,'vowed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66123,'vowel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66124,'voyage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66125,'wackiness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66126,'wad');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66131,'wafer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66132,'waffle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66133,'waged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66134,'wager');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66135,'wages');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66136,'waggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66141,'wagon');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66142,'wake');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66143,'waking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66144,'walk');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66145,'walmart');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66146,'walnut');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66151,'walrus');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66152,'waltz');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66153,'wand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66154,'wannabe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66155,'wanted');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66156,'wanting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66161,'wasabi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66162,'washable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66163,'washbasin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66164,'washboard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66165,'washbowl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66166,'washcloth');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66211,'washday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66212,'washed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66213,'washer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66214,'washhouse');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66215,'washing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66216,'washout');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66221,'washroom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66222,'washstand');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66223,'washtub');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66224,'wasp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66225,'wasting');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66226,'watch');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66231,'water');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66232,'waviness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66233,'waving');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66234,'wavy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66235,'whacking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66236,'whacky');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66241,'wham');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66242,'wharf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66243,'wheat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66244,'whenever');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66245,'whiff');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66246,'whimsical');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66251,'whinny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66252,'whiny');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66253,'whisking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66254,'whoever');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66255,'whole');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66256,'whomever');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66261,'whoopee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66262,'whooping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66263,'whoops');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66264,'why');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66265,'wick');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66266,'widely');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66311,'widen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66312,'widget');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66313,'widow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66314,'width');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66315,'wieldable');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66316,'wielder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66321,'wife');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66322,'wifi');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66323,'wikipedia');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66324,'wildcard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66325,'wildcat');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66326,'wilder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66331,'wildfire');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66332,'wildfowl');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66333,'wildland');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66334,'wildlife');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66335,'wildly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66336,'wildness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66341,'willed');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66342,'willfully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66343,'willing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66344,'willow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66345,'willpower');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66346,'wilt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66351,'wimp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66352,'wince');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66353,'wincing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66354,'wind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66355,'wing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66356,'winking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66361,'winner');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66362,'winnings');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66363,'winter');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66364,'wipe');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66365,'wired');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66366,'wireless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66411,'wiring');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66412,'wiry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66413,'wisdom');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66414,'wise');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66415,'wish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66416,'wisplike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66421,'wispy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66422,'wistful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66423,'wizard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66424,'wobble');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66425,'wobbling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66426,'wobbly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66431,'wok');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66432,'wolf');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66433,'wolverine');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66434,'womanhood');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66435,'womankind');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66436,'womanless');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66441,'womanlike');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66442,'womanly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66443,'womb');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66444,'woof');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66445,'wooing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66446,'wool');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66451,'woozy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66452,'word');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66453,'work');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66454,'worried');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66455,'worrier');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66456,'worrisome');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66461,'worry');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66462,'worsening');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66463,'worshiper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66464,'worst');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66465,'wound');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66466,'woven');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66511,'wow');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66512,'wrangle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66513,'wrath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66514,'wreath');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66515,'wreckage');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66516,'wrecker');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66521,'wrecking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66522,'wrench');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66523,'wriggle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66524,'wriggly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66525,'wrinkle');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66526,'wrinkly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66531,'wrist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66532,'writing');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66533,'written');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66534,'wrongdoer');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66535,'wronged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66536,'wrongful');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66541,'wrongly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66542,'wrongness');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66543,'wrought');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66544,'xbox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66545,'xerox');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66546,'yahoo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66551,'yam');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66552,'yanking');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66553,'yapping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66554,'yard');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66555,'yarn');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66556,'yeah');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66561,'yearbook');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66562,'yearling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66563,'yearly');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66564,'yearning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66565,'yeast');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66566,'yelling');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66611,'yelp');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66612,'yen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66613,'yesterday');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66614,'yiddish');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66615,'yield');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66616,'yin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66621,'yippee');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66622,'yo-yo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66623,'yodel');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66624,'yoga');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66625,'yogurt');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66626,'yonder');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66631,'yoyo');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66632,'yummy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66633,'zap');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66634,'zealous');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66635,'zebra');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66636,'zen');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66641,'zeppelin');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66642,'zero');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66643,'zestfully');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66644,'zesty');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66645,'zigzagged');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66646,'zipfile');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66651,'zipping');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66652,'zippy');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66653,'zips');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66654,'zit');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66655,'zodiac');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66656,'zombie');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66661,'zone');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66662,'zoning');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66663,'zookeeper');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66664,'zoologist');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66665,'zoology');
INSERT INTO [Wordlist] ([Roll],[Word]) 
VALUES (66666,'zoom');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
