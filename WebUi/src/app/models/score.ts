export interface IBaseScore {
  userId: number;
  value: number;
}

export interface IScore extends IBaseScore {
  _id: string;
}

export class Score implements IScore {
  _id: string;
  userId: number;
  value: number;

  constructor(_id: string = '', userId: number = 0, value: number = 0) {
    this._id = _id;
    this.userId = userId;
    this.value = value;
  }
}
