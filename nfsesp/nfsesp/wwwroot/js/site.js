addHandlerBtnsHistoryBack();
selectMainNavButton();

//#region "Sub-Rotinas"

function addHandlerBtnsHistoryBack() {
    const btnsHistoryBack = document.querySelectorAll('button[history-back]');

    btnsHistoryBack?.forEach(btn => {
        btn.addEventListener('click', () => {
            window.history.back();
        });
    });
}

function selectMainNavButton() {
    const actualLocation = window.location.pathname;

    if (!actualLocation.startsWith('/Main/')) return;

    const btn = document.querySelector(`a[href='${actualLocation}']`);

    btn.classList.add('selected');
}

//#endregion