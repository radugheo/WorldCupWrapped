import Match from "./MatchModel";

export default class Stadium {
    id!: string;
    name!: string;
    cityId!: string;
    capacity!: number;
    foundationYear!: number;
    picture!: string;
    matches!: Match[];
}