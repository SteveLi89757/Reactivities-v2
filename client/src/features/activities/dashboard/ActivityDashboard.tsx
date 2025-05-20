import { Grid } from "@mui/material";
import ActivityList from "./ActivityList";

export default function ActivityDashboard() {
  return (
    <Grid container>
      <Grid size={7}>
        <ActivityList />
      </Grid>
      <Grid size={5}>Activity filter go here</Grid>
    </Grid>
  );
}
