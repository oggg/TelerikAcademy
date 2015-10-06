<?xml version="1.0"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h1>Students</h1>
        <table bgcolor="#E0E0E0" cellspacing="1">
          <tr bgcolor="#EEEEEE">
            <td>
              <b>Name</b>
            </td>
            <td>
              <b>Gender</b>
            </td>
            <td>
              <b>Birth date</b>
            </td>
            <td>
              <b>Phone</b>
            </td>
            <td>
              <b>Mail</b>
            </td>
            <td>
              <b>Course</b>
            </td>
            <td>
              <b>Speciality</b>
            </td>
            <td>
              <b>Faculcy number</b>
            </td>
            <td>
              <b>Exams passed</b>
            </td>
          </tr>
          <xsl:for-each select="/students/student">
            <tr bgcolor="white">
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="gender"/>
              </td>
              <td>
                <xsl:value-of select="birth_date"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="speciality"/>
              </td>
              <td>
                <xsl:value-of select="faculcy_number"/>
              </td>
              <td>
                <table cellspacing="0">
                  <tr>
                    <td>
                      Exam title
                    </td>
                    <td>
                      Tutor
                    </td>
                    <td>
                      Score
                    </td>
                  </tr>
                  <xsl:for-each select="exams_passed/exam">
                    <tr>
                      <td>
                        <xsl:value-of select="exam_title"/>
                      </td>
                      <td>
                        <xsl:value-of select="tutor"/>
                      </td>
                      <td>
                        <xsl:value-of select="score"/>
                      </td>
                    </tr>
                  </xsl:for-each>
                </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>