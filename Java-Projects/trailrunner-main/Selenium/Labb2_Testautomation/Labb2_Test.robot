*** Settings ***
Documentation    test for rental5.infotiv.net    # info text
Library    SeleniumLibrary    # Which Library is being used

*** Variables ***
#Profile Variables
${firstName}    John
${lastName}    Doe
${phoneNumber}    0777123456
${cardNumber}    0556841111440090
${cardCVC}    667

#Login Variables
${userEmail}    JohnDoe@hotmail.com    # True Email
${userPass}    123abc    # True Password

${fakeEmail}    John.Doe@hotmail.com    # Incorrect Email
${fakePass}    123aBc    # Incorrect Password

#Repeated WebElements
#/Login Elements
${loginEmail}    //input[@id='email']
${loginPass}    //input[@id='password']
${loginButton}    //button[@id='login']
${loginInfoBox}    //div[@id='userInfoTop']

#/Booking Elements
${dateEnd}    //input[@id='end']
${dateContinue}    //button[@id='continue']

*** Test Cases ***
Scenario/Test1: User Login To Their Account
    [Documentation]    #http://rental5.infotiv.net/webpage/documentation/index.html#line2_1
    [Tags]    (VG_test) Test Login
    #Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User Is At The Start Page
    When User Inputs Their "${userEmail}" And "${userPass}" Login    ${userEmail}    ${userPass}
    Then User Should See Login Confirmation

Scenario/Test2: User Attempts To Book A Rental Car For Up To 5 Days
    [Documentation]    #http://rental5.infotiv.net/webpage/documentation/index.html#line2_2
    [Tags]    (VG_test) Test Booking For Rental
    #Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User Is At The Start Page
    When User Inputs Specified Date For Rental And Books One
    Then User Should Confirm The Booking Went Through

#Negativ Test Section - Must Always Confirm A Fail
Negative Scenario/Test1: User Attempts To Login With Incorrect Information
    [Documentation]    #http://rental5.infotiv.net/webpage/documentation/index.html#line2_1
    [Tags]    (VG_test) [Negative] False Login
    #Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User Is At The Start Page
    When User Incorrectly Inputs Their Login Information
    Then User Should Be Denied Access

# Filter Car Bug Test
Negative Scenario/Test2: User Filters A Specific Brand And Model Car
    [Documentation]    #http://rental5.infotiv.net/webpage/documentation/index.html#line2_3
    [Tags]    (VG_test) [Negative] Filter Rental Car
    #Set Selenium Speed    0.5    # Browser speed; lower = faster, higher = slower
    Given User Is At The Start Page
    When User Filters And Books The Specific Car
    Then The "Book" Button Should Be Missing Due To A Bug

*** Keywords ***
#Setup
User Is At The Start Page
    Open Browser    http://rental5.infotiv.net/    headlessChrome
    Wait Until Page Contains Element    //h1[@id='questionText']
    Wait Until Page Contains Element    ${dateContinue}

#Test Chapter 1 - User Login To Their Account
User Inputs Their "${userEmail}" And "${userPass}" Login
    [Arguments]    ${userEmail}    ${userPass}
    Input Text    ${loginEmail}    ${userEmail}
    Input Text    ${loginPass}    ${userPass}
    Click Button    ${loginButton}
    Wait Until Page Contains Element   ${loginInfoBox}
    Wait Until Page Contains    You are signed in as John

User Should See Login Confirmation
    Wait Until Page Contains Element   ${loginInfoBox}
    Wait Until Page Contains    You are signed in as John

#Test Chapter 2 - User Books A Rental Car
User Inputs Specified Date For Rental And Books One
    Input Text    ${loginEmail}    ${userEmail}
    Input Text    ${loginPass}    ${userPass}
    Click Button    ${loginButton}
    Click Element    ${dateEnd}
    Press Keys    ${dateEnd}    ARROW_RIGHT    ARROW_UP    ARROW_UP    ARROW_UP    ARROW_UP
    Click Button    ${dateContinue}
    Wait Until Page Contains    Tesla
    Wait Until Page Contains    Model S
    Wait Until Element Is Visible    //tbody/tr[15]/td[5]/form[1]/input[4]
    Click Element    //tbody/tr[15]/td[5]/form[1]/input[4]
    Wait Until Page Contains    Confirm booking of
    Input Text    //input[@id='cardNum']    ${cardNumber}
    Input Text    //input[@id='fullName']    John Doe
    Select From List By Index    //select[@title='Month']    7
    Select From List By Index    //select[@title='Year']    6
    Input Text    //input[@id='cvc']    ${cardCVC}
    Click Button    //button[@id='confirm']

User Should Confirm The Booking Went Through
    Page Should Contain    is now ready for pickup
    Page Should Contain Element    //div[@id='confirmMessage']

#Negative Test Chapter 1 - User Login With Incorrect Information

User Incorrectly Inputs Their Login Information
    Input Text    ${loginEmail}    John.Doe@hotmail.com    # Incorrect Email
    Input Text    ${loginPass}    123aBc    # Incorrect Password
    Click Button    ${loginButton}
    Wait Until Page Contains Element   ${loginInfoBox}

User Should Be Denied Access
    Page Should Contain Element    //label[@id='signInError']
    Page Should Contain    Wrong e-mail or password

#Negative Test Chapter 2 - User Filter Specific Brand/Model Of Car And Attempts To Book.
User Filters And Books The Specific Car
    Click Element    ${dateEnd}
    Press Keys    ${dateEnd}    ARROW_RIGHT    ARROW_UP    ARROW_UP    ARROW_UP    ARROW_UP    ARROW_UP
    Click Button    ${dateContinue}
    Click Element    //div[@id='ms-list-2']//button[@type='button']
    Click Element    //input[@id='ms-opt-9']
    Click Element    //div[@id='ms-list-2']//button[@type='button']
    Wait Until Page Contains    Opel
    Wait Until Page Contains    Vivaro
    Wait Until Page Contains Element    //img[@src='/webpage/img/vivaro.png']


The "Book" Button Should Be Missing Due To A Bug
    Page Should Not Contain Element    //tbody/tr[1]/td[5]/form[1]/input[4]
    Page Should Not Contain    Book