$("#calculategrade").click(function () {
    /*This program will be used to calculate the weighted grade average */
    var assignments, group_proj, quizzes, midterm, final, intex;

   /* Grab the values from the form*/
    assignments = parseInt($("#assignments").val());
    group_proj = parseInt($("#groupproject").val());
    quizzes = parseInt($("#quizzes").val());
    midterm = parseInt($("#midterm").val());
    final = parseInt($("#final").val());
    intex = parseInt($("#intex").val());

    /*Calculate the weighted average, rounded to 2 decimals*/
    weighted_avg = ((intex * .5) + (final * .1) + (midterm * .1) + (assignments * .1)
        + (group_proj * .1) + (quizzes * .1)).toFixed(2);

   /* Determine the letter grade*/
    if (weighted_avg >= 94) {
        letter_grade = "A";
    } else if (weighted_avg >= 90) {
        letter_grade = "A-";
    } else if (weighted_avg >= 87) {
        letter_grade = "B+";
    } else if (weighted_avg >= 84) {
        letter_grade = "B";
    } else if (weighted_avg >= 80) {
        letter_grade = "B-";
    } else if (weighted_avg >= 77) {
        letter_grade = "C+";
    } else if (weighted_avg >= 74) {
        letter_grade = "C";
    } else if (weighted_avg >= 70) {
        letter_grade = "C-";
    } else if (weighted_avg >= 67) {
        letter_grade = "D+";
    } else if (weighted_avg >= 64) {
        letter_grade = "D";
    } else if (weighted_avg >= 60) {
        letter_grade = "D-";
    } else {
        letter_grade = "E";
    }


    /*Display the letter grade and final percentage to the form*/
    $("#final_grade_avg").val(weighted_avg);
    $("#final_letter_grade").val(letter_grade);
})