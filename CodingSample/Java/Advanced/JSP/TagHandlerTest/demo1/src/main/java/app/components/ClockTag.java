package app.components;

import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;

import jakarta.servlet.jsp.JspException;
import jakarta.servlet.jsp.tagext.SimpleTagSupport;

public class ClockTag extends SimpleTagSupport{
    
    private SimpleDateFormat formatter = new SimpleDateFormat();

    public void setDisplayFormat(String value) {
        formatter.applyPattern(value);
    }

    @Override
    public void doTag() throws JspException, IOException {
        var context = super.getJspContext();
        var now = new Date();
        context.getOut().print(formatter.format(now));
    }

    
}
