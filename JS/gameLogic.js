// File that will cover all the functions for the game logic. These these are functions such as win conditions, loss conditions, and so on.


function didUserWin() {
    // Add parameters as you see fit.
    // Should be a boolean and just negate for the loss condition.
    let winCondition = false;
    
    return winCondition;
}


function generateCardsForGame(nCards){
    //TODO: add a value attribute to the cards 2 is backside up, 1 is face up, and 0 is no more card visible.
    // Here's how to do it: https://stackoverflow.com/questions/36096410/how-do-i-set-value-attribute-to-a-div-tag


    for (let i = 0; i < nCards; i++) {

        const cardList = document.getElementById("card-list");
        // Parent element to append all the cards to (ul). 

        const divContainer = document.createElement("div");
        const flippableCard = document.createElement("div");
        //instance of a card element to be stored on the dom.

        const cardInner = document.createElement("div");
        const cardFront = document.createElement("div");
        const cardBack  = document.createElement("div");
        const backImg = document.createElement("IMG");
        const frontImg = document.createElement("IMG");
        const chevron = document.createElement("li");
        //create all necessary elements for the cards in a game here.

        cardInner.setAttribute("class", "flip-card-inner");
        cardFront.setAttribute("class", "flip-card-front");
        cardBack.setAttribute("class", "flip-card-back");
        chevron.setAttribute("class", "chevron");
        flippableCard.setAttribute("class", "flip-card");
        // set the classes

        backImg.setAttribute("src", "../Img/back-of-card.png");
        backImg.setAttribute("width", "48px");
        backImg.setAttribute("height", "80px");
        frontImg.setAttribute("src", "../Img/card-front-tester.png");
        frontImg.setAttribute("width", "48px");
        frontImg.setAttribute("height", "80px");
        // set image attributes.

        cardFront.appendChild(frontImg);
        cardBack.appendChild(backImg);
        cardInner.appendChild(cardFront);
        cardInner.appendChild(cardBack);
        flippableCard.appendChild(cardInner);
        cardList.appendChild(flippableCard);
        // Append children.
                
    }

}



