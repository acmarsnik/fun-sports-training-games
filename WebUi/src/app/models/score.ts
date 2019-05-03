class Score {
    _id: string;
    userId: number;
    value: number;

    constructor(_id: string = "", userId: number = 0, value: number = 0) {
        this._id = _id;
        this.userId = userId;
        this.value = value;
    }
}