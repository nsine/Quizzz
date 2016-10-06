export default class AddQuizzCtrl {
    constructor (api) {
        this.api = api;

        this.file = null;
        this.status = '';
    }

    upload() {
        this.api.addQuizz(this.file)
            .then(() => {
                this.status = 'success';
            })
            .catch(() => {
                this.status = 'error';
            });
    }
}