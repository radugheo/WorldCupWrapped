import Trophy from "./TrophyModel";

export default class TeamTrophyResponse {
    teamName!: string;
    trophies?: Trophy[];
}